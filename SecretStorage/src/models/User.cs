using System.Drawing;

namespace SecretStorage.src.models
{
    /// <summary>
    /// Class to represent an authentificated user
    /// </summary>
    public class User
    {
        /// <summary>
        /// User unique id
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; set;  }

        /// <summary>
        /// User password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// User profile picture
        /// </summary>
        public Image ProfilePicture { get; set; }

        /// <summary>
        /// User logs
        /// </summary>
        public string Logs { get; set; }

        /// <summary>
        /// Define if a user is admin
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Init a new User
        /// </summary>
        /// <param name="id">Unique user id</param>
        /// <param name="name">User name</param>
        public User(uint id, string name)
        {
            Id = id;
            Name = name;
            Password = null;
            ProfilePicture = null;
            Logs = null;
        }

        /// <summary>
        /// Init a new User
        /// </summary>
        /// <param name="id">User unique id</param>
        /// <param name="name">User name</param>
        /// <param name="password">User password</param>
        public User(uint id, string name, string password, string logs, Image image)
        {
            Id = id;
            Name = name;
            Password = password;
            ProfilePicture = image;
            Logs = logs;
            MakeAdmin();
        }

        /// <summary>
        /// Make a user admin
        /// </summary>
        private void MakeAdmin()
        {
            if (Id == Properties.Settings.Default.AdminId)
            {
                IsAdmin = true;
            }
        }
    }
}
