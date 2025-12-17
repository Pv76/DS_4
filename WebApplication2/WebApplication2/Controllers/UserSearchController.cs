using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class UserSearchController
    {
        private readonly GitHubService _gitHubService;
        private readonly DatabaseContext _database;

        public UserSearchController(GitHubService gitHubService, DatabaseContext database)
        {
            _gitHubService = gitHubService;
            _database = database;
        }

        public async Task<UserSearchResult> SearchUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return new UserSearchResult
                {
                    Success = false,
                    ErrorMessage = "Please enter a valid username"
                };
            }

            var result = await _gitHubService.SearchUserAsync(username);

            if (result.Success)
            {
                try
                {
                    _database.SaveSearchHistory(username);
                }
                catch (Exception ex)
                {
                    // Log but don't fail the search
                    System.Diagnostics.Debug.WriteLine($"Failed to save history: {ex.Message}");
                }
            }

            return result;
        }

        public async Task<byte[]> GetAvatarImage(string avatarUrl)
        {
            return await _gitHubService.GetAvatarImageAsync(avatarUrl);
        }

        public List<SearchHistory> GetSearchHistory()
        {
            try
            {
                return _database.GetSearchHistory();
            }
            catch (Exception)
            {
                return new List<SearchHistory>();
            }
        }
    }
}