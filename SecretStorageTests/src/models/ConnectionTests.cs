using SecretStorage.src.models;
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
            User authUser = connection.Authentification("adrien", "adrien");
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
            User authUser = connection.Authentification("admin", "admin");
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
            User authUser = connection.Authentification("test", "azerty");
            Assert.IsNull(authUser);
        }

        /// <summary>
        /// Test IsDefaultImage method
        /// Test a user with default image
        /// </summary>
        [TestMethod()]
        public void IsDefaultImageTestWithDefaultImage()
        {
            Connection connection = new Connection();
            Assert.IsTrue(connection.IsDefaultImage(0));
        }

        /// <summary>
        /// Test IsDefaultImage method
        /// Test a user with no default image
        /// </summary>
        [TestMethod()]
        public void IsDefaultImageTestWithNoDefaultImage()
        {
            Connection connection = new Connection();
            Assert.IsFalse(connection.IsDefaultImage(2));
        }

        /// <summary>
        /// Test CheckIfLoginPagePassword method
        /// Test with a good password
        /// </summary>
        [TestMethod()]
        public void CheckIfGoodPasswordTestWithGoodPass()
        {
            Connection connection = new Connection();
            Assert.IsTrue(connection.CheckIfLoginPagePassword("123456"));
        }

        /// <summary>
        /// Test CheckIfLoginPagePassword method
        /// Test with a bad password
        /// </summary>
        [TestMethod()]
        public void CheckIfGoodPasswordTestWithBadPass()
        {
            Connection connection = new Connection();
            Assert.IsFalse(connection.CheckIfLoginPagePassword("BAD"));
        }

        /// <summary>
        /// Test GetAllUsers method
        /// </summary>
        [TestMethod()]
        public void GetAllUsersTest()
        {
            Connection connection = new Connection();
            Assert.IsNotNull(connection.GetAllUsers());
        }

        /// <summary>
        /// Test GetEncodedProfilPicture method
        /// Test with a valid user id
        /// </summary>
        [TestMethod()]
        public void GetEncodedProfilPictureTestWithValidUid()
        {
            Connection connection = new Connection();
            Assert.IsNotNull(connection.GetEncodedProfilPicture(1));
        }

        /// <summary>
        /// Test GetEncodedProfilPicture method
        /// Test with a bad user id
        /// </summary>
        [TestMethod()]
        public void GetEncodedProfilPictureTestWithBadUid()
        {
            Connection connection = new Connection();
            Assert.IsNull(connection.GetEncodedProfilPicture(0));
        }

        /// <summary>
        /// Test CheckIfNameIsUnique method
        /// Test with a non existing user
        /// </summary>
        [TestMethod()]
        public void CheckIfNameIsUniqueTestWithNonExistingUser()
        {
            Connection connection = new Connection();
            Assert.IsTrue(connection.CheckIfNameIsUnique("new user"));
        }

        /// <summary>
        /// Test CheckIfNameIsUnique method
        /// Test with an existing user
        /// </summary>
        [TestMethod()]
        public void CheckIfNameIsUniqueTestWithExistingUser()
        {
            Connection connection = new Connection();
            Assert.IsFalse(connection.CheckIfNameIsUnique("test"));
        }
    }
}