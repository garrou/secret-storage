using MySql.Data.MySqlClient;
using SecretStorage.src.utils;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.models
{
    /// <summary>
    /// Class to connect to MySQL database
    /// </summary>
    public class Connection
    { 
        /// <summary>
        /// Connection object to database
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Init a new connection
        /// </summary>
        public Connection()
        {
            connection = new MySqlConnection(Properties.Settings.Default.ConnectionString);
            connection.Open();
        }

        /// <summary>
        /// Authentificate a user
        /// </summary>
        /// <param name="name">Name to check</param>
        /// <param name="password">Password to check</param>
        /// <returns>A new user or null</returns>
        public User Authentification(string name, string password)
        {
            string sql = "SELECT u.id, u.name, u.password, i.picture, l.lastConnection "
                        + "FROM users AS u "
                        + "JOIN images AS i on i.userId = u.id "
                        + "JOIN logs AS l on u.id = l.userId "
                        + "WHERE u.name = @name AND u.password = @password";

            MySqlCommand command = new MySqlCommand(sql, connection);
            User user = null;

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = HydrateUtils.HydrateNewUser(ref reader);
                }
            }

            reader.Close();
            
            return user;
        }

        /// <summary>
        /// Check if passwordToCheck is the password 
        /// to access at the login page
        /// </summary>
        /// <param name="passwordToCheck">Password to check</param>
        /// <returns>true if good, false else</returns>
        public bool CheckIfLoginPagePassword(string passwordToCheck)
        {
            string sql = "SELECT password FROM gologin WHERE password = @password";
            MySqlCommand command = new MySqlCommand(sql, connection);
            bool isGood = false;

            command.Parameters.AddWithValue("@password", passwordToCheck);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                isGood = true;
            }

            reader.Close();

            return isGood;
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

            command.ExecuteNonQuery();
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
            bool isDefault = false;

            command.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(0).CompareTo(Properties.Settings.Default.DefaultImageName) == 0)
                    {
                        isDefault = true;
                    }
                }
            }

            reader.Close();

            return isDefault;
        }

        /// <summary>
        /// Update last connection of current user
        /// </summary>
        /// <param name="userId">User unique id</param>
        public bool UpdateLogs(uint userId)
        {
            string sql = "UPDATE logs SET lastConnection = @lastConnection WHERE userId = @userId";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@lastConnection", DateTime.Now);
            command.Parameters.AddWithValue("@userId", userId);
            
            return command.ExecuteNonQuery() == 1;
        }

        /// <summary>
        /// Update user name and password
        /// </summary>
        /// <param name="password">New user password</param>
        /// <param name="userId">User unique id</param>
        /// <returns>true if update, false else</returns>
        public void UpdatePassword(string password, uint userId)
        {
            string sql = "UPDATE users SET password = @password WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@id", userId);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Get the last connection of current useer
        /// </summary>
        /// <param name="userId">User unique id</param>
        /// <returns>The last connection date hours minutes seconds</returns>
        public string GetLogs(uint userId)
        {
            string sql = "SELECT lastConnection FROM logs WHERE userId = @userId";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string lastConnection = string.Empty;

            command.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read()) 
                {
                    lastConnection = reader.GetString(0);
                }
            }

            reader.Close();

            return lastConnection;
        }

        /// <summary>
        /// Check if name is in users table
        /// </summary>
        /// <param name="nameToCheck">Name to check</param>
        /// <returns>true if a user exists, false else</returns>
        public bool CheckIfNameIsUnique(string nameToCheck)
        {
            string sql = "SELECT name FROM users WHERE name = @name";
            MySqlCommand command = new MySqlCommand(sql, connection);
            bool isUnique = true;

            command.Parameters.AddWithValue("@name", nameToCheck);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                isUnique = false;
            }

            reader.Close();

            return isUnique;
        }

        /// <summary>
        /// Insert in users table a new user
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="password">User password</param>
        /// <returns>The number of inserted row</returns>
        public int InsertNewUser(string name, string password)
        {
            string sql = "INSERT INTO users (name, password) VALUES (@name, @password)";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);
            
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Insert an image in database
        /// with user name and user password
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="password">User password</param>
        /// <returns>The number of inserted row</returns>
        public int InsertNewImage(string name, string password)
        {
            string sql = "INSERT INTO images (userId, picture) "
                         + "SELECT id, 'user.png' " 
                         + "FROM users "
                         + "WHERE name = @name AND password = @password";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);

            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Insert new logs in database
        /// with user name in user password
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="password">User password</param>
        /// <returns>The number of inserted row</returns>
        public int InsertNewLog(string name, string password)
        {
            string sql = "INSERT INTO logs (userId, lastConnection) "
                         + "SELECT id, NOW() "
                         + "FROM users "
                         + "WHERE name = @name AND password = @password";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@password", password);

            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Retrieve data of current user
        /// </summary>
        /// <param name="toRefresh">User to refresh</param>
        public void RefreshCurrentUser(ref User toRefresh)
        {
            string sql = "SELECT u.id, u.name, u.password, i.picture, l.lastConnection "
                        + "FROM users AS u "
                        + "JOIN images AS i on i.userId = u.id "
                        + "JOIN logs AS l on u.id = l.userId "
                        + "WHERE u.id = @id";

            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", toRefresh.Id);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HydrateUtils.HydrateCurrentUser(ref reader, ref toRefresh);
                }
            }

            reader.Close();
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
