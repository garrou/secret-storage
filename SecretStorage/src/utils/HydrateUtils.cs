using MySql.Data.MySqlClient;
using SecretStorage.src.models;
using System.Drawing;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// Class to init object properties
    /// with database data
    /// </summary>
    public class HydrateUtils
    {
        /// <summary>
        /// Init a user with the database data
        /// </summary>
        /// <param name="reader">MySqlDataReader</param>
        /// <returns>The created user</returns>
        public static User HydrateNewUser(ref MySqlDataReader reader)
        {
            long len;
            byte[] encodedPicture;
            Image profilePicture;

            if (reader.GetString(3).CompareTo(Properties.Settings.Default.DefaultImageName) == 0)
            {
                profilePicture = null;
            } 
            else 
            {
                len = reader.GetBytes(3, 0, null, 0, 0);
                encodedPicture = new byte[len];
                reader.GetBytes(3, 0, encodedPicture, 0, (int)len);
                profilePicture = ImageUtils.FromBytesToImage(encodedPicture);
            }

            len = reader.GetBytes(3, 0, null, 0, 0);
            encodedPicture = new byte[len];
            reader.GetBytes(3, 0, encodedPicture, 0, (int)len);

            User user = new User(uint.Parse(reader["id"].ToString()),
                                reader["name"].ToString(),
                                reader["password"].ToString(),
                                reader["lastConnection"].ToString(),
                                profilePicture);

            return user;
        }

        /// <summary>
        /// Init current user with the database data
        /// </summary>
        /// <param name="reader">MySqlDataReader</param>
        /// <returns>The created user</returns>
        public static void HydrateCurrentUser(ref MySqlDataReader reader, ref User currentUser)
        {
            long len;
            byte[] encodedPicture;

            len = reader.GetBytes(3, 0, null, 0, 0);
            encodedPicture = new byte[len];
            reader.GetBytes(3, 0, encodedPicture, 0, (int)len);

            currentUser.Id = uint.Parse(reader["id"].ToString());
            currentUser.Name = reader["name"].ToString();
            currentUser.Password = reader["password"].ToString();
            currentUser.Logs = reader["lastConnection"].ToString();
            currentUser.ProfilePicture = ImageUtils.FromBytesToImage(encodedPicture);
        }
    }
}
