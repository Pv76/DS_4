using System.Net.Http;
using Newtonsoft.Json.Linq;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class GitHubService
    {
        private const string GITHUB_API_BASE = "https://api.github.com";
        private readonly HttpClient _httpClient;

        public GitHubService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("GitHubSearchApp/1.0");
            _httpClient.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github.v3+json");
        }

        public async Task<UserSearchResult> SearchUserAsync(string username)
        {
            try
            {
                // Get user info
                var userResponse = await _httpClient.GetStringAsync($"{GITHUB_API_BASE}/users/{username}");
                var userJson = JObject.Parse(userResponse);

                var user = new GitHubUser
                {
                    Login = userJson["login"].ToString(),
                    AvatarUrl = userJson["avatar_url"].ToString(),
                    Followers = (int)userJson["followers"],
                    PublicRepos = (int)userJson["public_repos"],
                    CreatedAt = DateTime.Parse(userJson["created_at"].ToString())
                };

                // Get repositories
                var reposResponse = await _httpClient.GetStringAsync($"{GITHUB_API_BASE}/users/{username}/repos?per_page=100");
                var reposJson = JArray.Parse(reposResponse);

                var topRepos = reposJson
                    .Select(r => new Repository
                    {
                        Name = r["name"].ToString(),
                        StargazersCount = (int)r["stargazers_count"],
                        ForksCount = (int)r["forks_count"]
                    })
                    .OrderByDescending(r => r.TotalScore)
                    .Take(4)
                    .ToList();

                return new UserSearchResult
                {
                    User = user,
                    TopRepositories = topRepos,
                    Success = true
                };
            }
            catch (HttpRequestException)
            {
                return new UserSearchResult
                {
                    Success = false,
                    ErrorMessage = "User not found or API error occurred"
                };
            }
            catch (Exception ex)
            {
                return new UserSearchResult
                {
                    Success = false,
                    ErrorMessage = $"Error: {ex.Message}"
                };
            }
        }

        public async Task<byte[]> GetAvatarImageAsync(string avatarUrl)
        {
            return await _httpClient.GetByteArrayAsync(avatarUrl);
        }
    }
}
