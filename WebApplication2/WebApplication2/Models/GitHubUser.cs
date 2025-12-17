namespace WebApplication2.Models
{
    public class GitHubUser
    {
        public string Login { get; set; }
        public string AvatarUrl { get; set; }
        public int Followers { get; set; }
        public int PublicRepos { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Repository
    {
        public string Name { get; set; }
        public int StargazersCount { get; set; }
        public int ForksCount { get; set; }
        public int TotalScore => StargazersCount + ForksCount;
    }

    public class SearchHistory
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime SearchDate { get; set; }
    }

    public class UserSearchResult
    {
        public GitHubUser User { get; set; }
        public List<Repository> TopRepositories { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
