using System;

namespace GitHubSearch
{
    public class SearchHistory
    {
        public int SearchID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public int Followers { get; set; }
        public int PublicRepos { get; set; }
        public DateTime SearchDate { get; set; }
        public DateTime LastSearched { get; set; }
    }
}
