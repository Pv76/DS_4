using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using Newtonsoft.Json;

namespace GitHubSearch
{
    public partial class Default : System.Web.UI.Page
    {
        private static readonly HttpClient client = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("GitHubSearchApp/1.0");
                LoadSearchHistory();
            }
        }

        private void LoadSearchHistory()
        {
            try
            {
                List<SearchHistory> history = SearchHistoryData.GetAllSearchHistory();
                
                if (history != null && history.Count > 0)
                {
                    rptSearchHistory.DataSource = history;
                    rptSearchHistory.DataBind();
                    pnlSearchHistory.Visible = true;
                }
                else
                {
                    pnlSearchHistory.Visible = false;
                }
            }
            catch
            {
                pnlSearchHistory.Visible = false;
            }
        }

        protected async void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                ShowError("Ingrese un username de GitHub");
                return;
            }

            await PerformSearch(username);
        }

 
        private async Task PerformSearch(string username)
        {
            try
            {

                var userInfo = await GetUserInfo(username);

                if (userInfo == null)
                {
                    ShowError($"Usuario '{username}' no disponible. Revise el username ");
                    return;
                }

                SearchHistoryData.SaveSearchHistory(userInfo);

                LoadSearchHistory();


                var repositories = await GetAllPublicRepositories(username);

                if (repositories == null || repositories.Count == 0)
                {
                    ShowError($"No existe repos publica de '{username}'");
                    return;
                }

                var timelineRepos = repositories
                    .OrderByDescending(r => DateTime.Parse(r.created_at))
                    .ToList();

                DisplayUserInfo(userInfo, timelineRepos);

                lblError.Visible = false;
                pnlUserInfo.Visible = true;
            }
            catch (Exception ex)
            {
                ShowError($"An error occurred: {ex.Message}");
            }
        }

        private async Task<GitHubUser> GetUserInfo(string username)
        {
            string url = $"https://api.github.com/users/{username}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GitHubUser>(json);
            }
            catch
            {
                return null;
            }
        }

        private async Task<List<GitHubRepository>> GetAllPublicRepositories(string username)
        {
            List<GitHubRepository> allRepositories = new List<GitHubRepository>();
            int page = 1;
            int perPage = 50;
            bool hasMore = true;

            try
            {
                while (hasMore)
                {
                    string url = $"https://api.github.com/users/{username}/repos?per_page={perPage}&page={page}&sort=created&direction=desc&type=public";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        return allRepositories.Count > 0 ? allRepositories : new List<GitHubRepository>();
                    }

                    string json = await response.Content.ReadAsStringAsync();
                    var repos = JsonConvert.DeserializeObject<List<GitHubRepository>>(json);

                    if (repos == null || repos.Count == 0)
                    {
                        hasMore = false;
                    }
                    else
                    {
                        allRepositories.AddRange(repos);
                        page++;
                    }
                }
            }
            catch
            {
                return allRepositories.Count > 0 ? allRepositories : new List<GitHubRepository>();
            }

            return allRepositories;
        }

        private void DisplayUserInfo(GitHubUser user, List<GitHubRepository> repos)
        {
            imgAvatar.ImageUrl = user.avatar_url;
            lblName.Text = string.IsNullOrEmpty(user.name) ? user.login : user.name;
            lblUsername.Text = user.login;
            lblFollowers.Text = user.followers.ToString("");
            lblRepoCount.Text = user.public_repos.ToString("");

            rptRepositories.DataSource = repos;
            rptRepositories.DataBind();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
            pnlUserInfo.Visible = false;
        }

        protected async void lnkSearchHistory_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            if (e.CommandName == "Search")
            {
                string username = e.CommandArgument.ToString();
                txtUsername.Text = username;
                await PerformSearch(username);
            }
            else if (e.CommandName == "Delete")
            {
                if (int.TryParse(e.CommandArgument.ToString(), out int searchID))
                {
                    SearchHistoryData.DeleteSearchHistory(searchID);
                    LoadSearchHistory();
                }
            }
        }

        protected void btnClearHistory_Click(object sender, EventArgs e)
        {
            SearchHistoryData.ClearHistory();
            LoadSearchHistory();
            lblError.Visible = false;
        }
    }

    public class GitHubUser
    {
        public string login { get; set; }
        public string name { get; set; }
        public string avatar_url { get; set; }
        public int followers { get; set; }
        public int public_repos { get; set; }
    }

    public class GitHubRepository
    {
        public string name { get; set; }
        public string description { get; set; }
        public int stargazers_count { get; set; }
        public int forks_count { get; set; }
        public string created_at { get; set; }
        public string html_url { get; set; }
        public bool private_repo { get; set; }
    }
}