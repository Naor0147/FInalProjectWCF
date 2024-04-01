using FInalProject.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FInalProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private const string ConnectionString =
          @"Data Source=DESKTOP-RVNQ78B;" +
          @"Initial Catalog=RachelDB;" +
          @"Integrated Security=True";



        public bool RegisterUser(User user)
        {
            if (HasUsername(user.Name))
                return false;

            string query = $"insert into Users (Name, Password,Mail,YearBorn) values('{user.Name}', '{user.Password}','{user.Mail}',{user.YearBorn})";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                return cmd.ExecuteNonQuery() != 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }



        public List<User> GetUsers()
        {
            string query = $"select * from Users";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            List<User> players = new List<User>();

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    players.Add(new User((string)reader["Name"], (string)reader["Password"], (string)reader["Mail"], (int)reader["YearBorn"]));
                }
                reader.Close();
                return players;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return players;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }


        public bool ValidateUser(User user)
        {
            string query = $"select * from Users where Name='{user.Name}' and password='{user.Password}'";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public User Login(string username, string password)
        {
            string query = $"select * from Users where Name='{username}' and password='{password}'";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            List<User> players = new List<User>();

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    players.Add(new User((string)reader["Name"], (string)reader["Password"], (string)reader["Mail"], (int)reader["YearBorn"]));
                }
                reader.Close();
                return players[0];

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }


        public bool HasUsername(string username)
        {
            string query = $"select * from Users where Name='{username}'";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public bool AddStats(LevelStats levelStats)
        {
            if (!HasUsername(levelStats.Name))
                return false;

            string query = $"insert into PlayerStats (Name, TimePassed,Coins,NumberOfCoins,TimeClicked,LevelId) values('{levelStats.Name}', {levelStats.TimePassed},{levelStats.Coins},{levelStats.NumberOfCoins},{levelStats.TimeClicked},{levelStats.LevelId})";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                return cmd.ExecuteNonQuery() != 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public List<LevelStats> GetLevelStats()
        {
            string query = $"select * from PlayerStats";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            List<LevelStats> Stats = new List<LevelStats>();

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Stats.Add(new LevelStats((string)reader["Name"], (int)reader["TimePassed"], (int)reader["Coins"], (int)reader["NumberOfCoins"], (int)reader["TimeClicked"], (int)reader["LevelId"], (int)reader["Id"]));
                }
                reader.Close();
                return Stats;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return Stats;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }

        public List<LevelStats> GetLevelStatsPerUser(string Name)
        {
            string query = $"select * from PlayerStats where Name='{Name}' ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            List<LevelStats> Stats = new List<LevelStats>();

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Stats.Add(new LevelStats((string)reader["Name"], (int)reader["TimePassed"], (int)reader["Coins"], (int)reader["NumberOfCoins"], (int)reader["TimeClicked"], (int)reader["LevelId"], (int)reader["Id"]));
                }
                reader.Close();
                return Stats;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return Stats;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }



        }
        public LevelStats GetLevelStatsById(int id)
        {
            string query = $"select * from PlayerStats where Id='{id}' ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                LevelStats Stats = (new LevelStats((string)reader["Name"], (int)reader["TimePassed"], (int)reader["Coins"], (int)reader["NumberOfCoins"], (int)reader["TimeClicked"], (int)reader["LevelId"], (int)reader["Id"]));

                reader.Close();
                return Stats;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }


        public List<LevelStats> GetLevelStatsByLevelId(int LevelId)
        {
            string query = $"select * from PlayerStats where LevelId={LevelId} ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            List<LevelStats> Stats = new List<LevelStats>();

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Stats.Add(new LevelStats((string)reader["Name"], (int)reader["TimePassed"], (int)reader["Coins"], (int)reader["NumberOfCoins"], (int)reader["TimeClicked"], (int)reader["LevelId"], (int)reader["Id"]));
                }
                reader.Close();
                return Stats;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return Stats;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }

        public List<UserAndLevel> GetAvgScore()
        {
            string query = $"SELECT u.Name, u.Password,u.Mail, u.YearBorn,\r\n       AVG(ps.TimePassed) AS TimePassed, \r\n       AVG(ps.Coins) AS Coins, \r\n       AVG(ps.NumberOfCoins) AS NumberOfCoins, \r\n       AVG(ps.TimeClicked) AS TimeClicked, \r\n       Avg(ps.LevelId) AS LevelId,\r\n\t   AVG(ps.Id) As Id\r\nFROM Users u\r\nINNER JOIN PlayerStats ps ON u.Name = ps.Name\r\nGROUP BY u.Name,u.Password, u.Mail, u.YearBorn;\r\n ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            List<UserAndLevel> Stats = new List<UserAndLevel>();

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Stats.Add(new UserAndLevel(new User((string)reader["Name"], (string)reader["Password"], (string)reader["Mail"], (int)reader["YearBorn"]), new LevelStats((string)reader["Name"], (int)reader["TimePassed"], (int)reader["Coins"], (int)reader["NumberOfCoins"], (int)reader["TimeClicked"], (int)reader["LevelId"], (int)reader["Id"])));
                }
                reader.Close();
                return Stats;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return Stats;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }

        public User FindUser(string username){
            string query = $"select * from Users where Name ='{username}'";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
           

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                User player= new User((string)reader["Name"], (string)reader["Password"], (string)reader["Mail"], (int)reader["YearBorn"]);
                
                reader.Close();
                return player;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }
        public int test()
        {
            return 5;
        }
        public bool black() {  return true; }

    }
    }
