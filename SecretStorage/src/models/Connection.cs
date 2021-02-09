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
        private readonly string connectionStr = Properties.Settings.Default.ConnectionString;

        /// <summary>
        /// Connection object to database
        /// </summary>
        private readonly MySqlConnection connection;

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

            if (reader.HasRows)
            {
                while (reader.Read())
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
            MessageBox.Show("Commande effectuée avec succés.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usersList.Add(new User(uint.Parse(reader["id"].ToString()),
                                                      reader["name"].ToString(),
                                                      reader["password"].ToString()));
                }
            }

            reader.Close();

            return usersList;
        }

        /// <summary>
        /// Get the current profile picture of authentified user
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <returns>The encoded image</returns>
        public byte[] GetEncodedProfilPicture(uint userId)
        {
            string sql = "SELECT picture FROM images WHERE userId = @userId";
            MySqlCommand command = new MySqlCommand(sql, connection);
            byte[] encodedPicture = null;
            long len;

            command.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    len = reader.GetBytes(0, 0, null, 0, 0);
                    encodedPicture = new byte[len];
                    reader.GetBytes(0, 0, encodedPicture, 0, (int)len);
                }
            }

            reader.Close();

            return encodedPicture;
        }

        /// <summary>
        /// Update profile picture
        /// </summary>
        /// <param name="bytes">Encoded profile photo</param>
        /// <param name="userId">User id who update his picture</param>
        public void UpdateProfilePicture(byte[] bytes, uint userId)
        {
            string sql = "UPDATE images SET picture = @bytes WHERE userId = @userId";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@bytes", bytes);
            command.Parameters.AddWithValue("@userId", userId);

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Photo de profil modifiée avec succés.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Impossible de modifier la photo de profil.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Check is user has a default profile picture
        /// </summary>
        /// <param name="userId">User unique id</param>
        /// <returns>true if user has a default image, false else</returns>
        public bool IsDefaultImage(uint userId)
        {
            string sql = "SELECT picture FROM images WHERE userId = @userId";
            MySqlCommand command = new MySqlCommand(sql, connection);
            bool isDefault = true;

            command.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(0).CompareTo(Properties.Settings.Default.DefaultImage) != 0)
                    {
                        isDefault = false;
                    }
                }
            }

            reader.Close();

            return isDefault;
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        public void Close()
        {
            connection.Close();
        }
    }
}
