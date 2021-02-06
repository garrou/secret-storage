using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretStorage.src.models
{
    /// <summary>
    /// Class to connect to MySQL database
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// Connection string to database
        /// </summary>
        private string connectionStr = "server=localhost;user=root;database=secretstorage;port=3306;password=root";

        /// <summary>
        /// Connection object to database
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// Init a new connection
        /// </summary>
        public Connection()
        {
            connection = new MySqlConnection(connectionStr);
            connection.Open();
        }

        /// <summary>
        /// Authentificate a user
        /// </summary>
        /// <param name="password">Password to check</param>
        /// <returns>A new user or null</returns>
        public User Authentification(string password)
        {
            string sql = "SELECT id, name, password FROM users WHERE password=@password LIMIT 1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            User user = null;

            command.Parameters.AddWithValue("@password", password);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader["id"] != null && reader["name"] != null && reader["password"] != null)
                {
                    user = new User(uint.Parse(reader["id"].ToString()), 
                                               reader["name"].ToString(), 
                                               reader["password"].ToString());
                } 
            }

            reader.Close();
            
            return user;
        }

        /// <summary>
        /// Execute a SQL command
        /// </summary>
        /// <param name="sqlCommand">SQL command to execute</param>
        public void Execute(string sqlCommand)
        {
            MySqlCommand command = new MySqlCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Commande effectuée avec succés.", "Succés !", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Get all users from database
        /// </summary>
        /// <returns>Returns a list of all users in database</returns>
        public List<User> GetAllUsers()
        {
            string sql = "SELECT id, name, password FROM users";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<User> usersList = new List<User>();

            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                usersList.Add(new User(uint.Parse(reader["id"].ToString()), 
                                                  reader["name"].ToString(), 
                                                  reader["password"].ToString()));
            }

            reader.Close();

            return usersList;
        }
    }
}
