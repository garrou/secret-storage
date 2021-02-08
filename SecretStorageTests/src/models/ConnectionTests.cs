using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.models.Tests
{
    /// <summary>
    /// Test Connection class
    /// </summary>
    [TestClass()]
    public class ConnectionTests
    {
        /// <summary>
        /// Test Authentification method
        /// Test if a user in is database
        /// </summary>
        [TestMethod()]
        public void AuthentificationTestUser()
        {
            Connection connection = new Connection();
            User authUser = connection.Authentification("987654");

            Assert.IsNotNull(authUser);
        }

        /// <summary>
        /// Test Authentification method
        /// Test if returned user is in admin
        /// </summary>
        [TestMethod()]
        public void AuthentificationTestAdmin()
        {
            Connection connection = new Connection();
            User authUser = connection.Authentification("123456");

            Assert.AreEqual(authUser.IsAdmin, true);
        }

        /// <summary>
        /// Test Authentification method
        /// Test if nobody is in user table
        /// </summary>
        [TestMethod()]
        public void AuthentificationTestNobody()
        {
            Connection connection = new Connection();
            User authUser = connection.Authentification("azerty");

            Assert.IsNull(authUser);
        }
    }
}