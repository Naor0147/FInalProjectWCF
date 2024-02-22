using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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




    
    }
}
