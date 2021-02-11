using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

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
            User created = new User(1, "test", "test", DateTime.Now.ToString(), new Bitmap("../../assets/cs.png"));
            Assert.IsNotNull(created);
        }

        /// <summary>
        /// Test constructor
        /// Test if user is admin
        /// </summary>
        [TestMethod()]
        public void UserTestIsAdmin()
        {
            User created = new User(2, "admin", "admin", DateTime.Now.ToString(), new Bitmap("../../assets/cs.png"));
            Assert.IsTrue(created.IsAdmin);
        }

        /// <summary>
        /// Test constructor
        /// Test if user is not admin
        /// </summary>
        [TestMethod()]
        public void UserTestIsNotAdmin()
        {
            User created = new User(1, "admin", "admin", DateTime.Now.ToString(), new Bitmap("../../assets/cs.png"));
            Assert.IsFalse(created.IsAdmin);
        }
    }
}