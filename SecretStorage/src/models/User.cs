using System;

namespace SecretStorage.src.models
{
    public class User
    {
        private string name;

        private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
