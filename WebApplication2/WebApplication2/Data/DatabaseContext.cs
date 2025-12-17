using WebApplication2.Models;
using System.Data.SqlClient;
using WebApplication2.Models;
namespace WebApplication2.Data
{
    public class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string createTableQuery = @"
                        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SearchHistory')
                        CREATE TABLE SearchHistory (
                            Id INT PRIMARY KEY IDENTITY(1,1),
                            Username NVARCHAR(100) NOT NULL,
                            SearchDate DATETIME NOT NULL DEFAULT GETDATE()
                        )";
                    using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database initialization failed: {ex.Message}", ex);
            }
        }

        public void SaveSearchHistory(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SearchHistory (Username, SearchDate) VALUES (@Username, GETDATE())";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SearchHistory> GetSearchHistory(int limit = 20)
        {
            var history = new List<SearchHistory>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT TOP (@Limit) Id, Username, SearchDate FROM SearchHistory ORDER BY SearchDate DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Limit", limit);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            history.Add(new SearchHistory
                            {
                                Id = (int)reader["Id"],
                                Username = reader["Username"].ToString(),
                                SearchDate = (DateTime)reader["SearchDate"]
                            });
                        }
                    }
                }
            }
            return history;
        }
    }
}
