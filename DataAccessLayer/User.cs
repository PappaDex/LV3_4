using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public List<User> GetUsers()
        {

            List<User> users = new List<User>();
            string connectionString = "Server=DESKTOP-GV9CUPH\\SQLEXPRESS;Database=LV2022;Trusted_Connection=True;";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User()
                        {
                            UserID = (int)reader["USER_ID"],
                            UserName = (string)reader["USERNAME"],
                            UserPassword = (string)reader["PASSWORD"],
                            UserFirstName = (string)reader["NAME"],
                            UserLastName = (string)reader["SURNAME"]
                        });
                    }
                }
            }
            return users;
        }
        public void UpdateUsers(User oUser)
        {
            string sSqlConnectionString = "Server=DESKTOP-GV9CUPH\\SQLEXPRESS;Database=LV2022;Trusted_Connection=True;";
    using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE users SET NAME = '" + oUser.UserFirstName +"', SURNAME = '" + oUser.UserLastName + "', PASSWORD = '" + oUser.UserName + "' WHERE USER_ID = "+oUser.UserID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }
            }
        }
        public void AddUser(User oUser)
        {
            string sSqlConnectionString = "Server=DESKTOP-GV9CUPH\\SQLEXPRESS;Database=LV2022;Trusted_Connection=True;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO users (USERNAME, PASSWORD, NAME,SURNAME) VALUES('" + oUser.UserName + "', '" + oUser.UserPassword + "', '" + oUser.UserFirstName + "', '" + oUser.UserLastName + "');";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }
            }
        }
        public void DeleteUsers(int IDObrisanog)
        {
            string sSqlConnectionString = "Server=DESKTOP-GV9CUPH\\SQLEXPRESS;Database=LV2022;Trusted_Connection=True;";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM users WHERE USER_ID = " + IDObrisanog;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }
            }
        }
    }

    
}

