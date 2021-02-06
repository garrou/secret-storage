namespace SecretStorage.src.models
{
    /// <summary>
    /// Class to represent an authentificated user
    /// </summary>
    public class User
    {
        public uint Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Init a new User
        /// </summary>
        /// <param name="id">User unique id</param>
        /// <param name="name">User name</param>
        /// <param name="password">User password</param>
        public User(uint id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
