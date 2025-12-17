using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GitHubSearch
{

    public class SearchHistoryData
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["conexion"]?.ConnectionString ?? "";

        public static bool SaveSearchHistory(GitHubUser user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM SearchHistory WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", user.login);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = @"UPDATE SearchHistory 
                                                 SET Name = @Name, 
                                                     AvatarUrl = @AvatarUrl, 
                                                     Followers = @Followers, 
                                                     PublicRepos = @PublicRepos,
                                                     LastSearched = GETDATE()
                                                 WHERE Username = @Username";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@Username", user.login);
                                updateCmd.Parameters.AddWithValue("@Name", user.name ?? "");
                                updateCmd.Parameters.AddWithValue("@AvatarUrl", user.avatar_url ?? "");
                                updateCmd.Parameters.AddWithValue("@Followers", user.followers);
                                updateCmd.Parameters.AddWithValue("@PublicRepos", user.public_repos);

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"INSERT INTO SearchHistory 
                                                (Username, Name, AvatarUrl, Followers, PublicRepos, SearchDate, LastSearched)
                                                VALUES 
                                                (@Username, @Name, @AvatarUrl, @Followers, @PublicRepos, GETDATE(), GETDATE())";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@Username", user.login);
                                insertCmd.Parameters.AddWithValue("@Name", user.name ?? "");
                                insertCmd.Parameters.AddWithValue("@AvatarUrl", user.avatar_url ?? "");
                                insertCmd.Parameters.AddWithValue("@Followers", user.followers);
                                insertCmd.Parameters.AddWithValue("@PublicRepos", user.public_repos);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<SearchHistory> GetAllSearchHistory()
        {
            List<SearchHistory> searchHistory = new List<SearchHistory>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                {
                    string query = "SELECT SearchID, Username, Name, AvatarUrl, Followers, PublicRepos, SearchDate, LastSearched " +
                                 "FROM SearchHistory ORDER BY LastSearched DESC";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                searchHistory.Add(new SearchHistory
                                {
                                    SearchID = (int)reader["SearchID"],
                                    Username = reader["Username"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    AvatarUrl = reader["AvatarUrl"].ToString(),
                                    Followers = (int)reader["Followers"],
                                    PublicRepos = (int)reader["PublicRepos"],
                                    SearchDate = (DateTime)reader["SearchDate"],
                                    LastSearched = (DateTime)reader["LastSearched"]
                                });
                            }
                        }
                    }
                }
            }
            catch
            {

            }

            return searchHistory;
        }


        public static SearchHistory GetHistoryByUser(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT SearchID, Username, Name, AvatarUrl, Followers, PublicRepos, SearchDate, LastSearched " +
                                 "FROM SearchHistory WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new SearchHistory
                                {
                                    SearchID = (int)reader["SearchID"],
                                    Username = reader["Username"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    AvatarUrl = reader["AvatarUrl"].ToString(),
                                    Followers = (int)reader["Followers"],
                                    PublicRepos = (int)reader["PublicRepos"],
                                    SearchDate = (DateTime)reader["SearchDate"],
                                    LastSearched = (DateTime)reader["LastSearched"]
                                };
                            }
                        }
                    }
                }
            }
            catch
            {

            }

            return null;
        }

        public static bool DeleteSearchHistory(int searchID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM SearchHistory WHERE SearchID = @SearchID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchID", searchID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool ClearHistory()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM SearchHistory";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
