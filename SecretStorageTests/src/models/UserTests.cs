using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.models.Tests
{
    /// <summary>
    /// Tests User class
    /// </summary>
    [TestClass()]
    public class UserTests
    {
        /// <summary>
        /// Test constructor
        /// Test if user is not null
        /// </summary>
        [TestMethod()]
        public void UserTestIsNotNull()
        {
            User created = new User(1, "test", "test");
            Assert.IsNotNull(created);
        }

        /// <summary>
        /// Test constructor
        /// Test if user is admin
        /// </summary>
        [TestMethod()]
        public void UserTestIsAdmin()
        {
            User created = new User(1, "admin", "test");
            Assert.IsTrue(created.IsAdmin);
        }

        /// <summary>
        /// Test constructor
        /// Test if user is not admin
        /// </summary>
        [TestMethod()]
        public void UserTestIsNotAdmin()
        {
            User created = new User(1, "administrator", "test");
            Assert.IsFalse(created.IsAdmin);
        }
    }
}