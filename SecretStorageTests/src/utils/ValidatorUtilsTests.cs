using SecretStorage.src.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using SecretStorage.src.models;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test ValidatorUtils class
    /// </summary>
    [TestClass]
    public class ValidatorUtilsTests
    {
        /// <summary>
        /// Test IsValidUpdatePassword method
        /// With good parameters
        /// </summary>
        [TestMethod]
        public void IsValidToUpdatePasswordTestGood()
        {
            bool isValid = ValidatorUtils.IsValidToUpdatePassword("123456", "123456");
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// Test IsValidUpdatePassword method
        /// With not same password
        /// </summary>
        [TestMethod]
        public void IsValidToUpdatePasswordTestNotSame()
        {
            bool isValid = ValidatorUtils.IsValidToUpdatePassword("12345678910", "123456");
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Test IsValidUpdatePassword method
        /// With short password
        /// </summary>
        [TestMethod]
        public void IsValidToUpdatePasswordTestWithShortPassword()
        {
            bool isValid = ValidatorUtils.IsValidToUpdatePassword("123", "123");
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Test IsValidToUpdateProfile method
        /// With valid parameters
        /// </summary>
        [TestMethod]
        public void IsValidToUpdateProfileTestGood()
        {
            PictureBox picture = new PictureBox
            {
                ImageLocation = "../../assets/cs.png"
            };

            bool isValid = ValidatorUtils.IsValidToUpdateProfile("123456", "123456", picture);
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// Test IsValidToUpdateProfile method
        /// With valid parameters
        /// </summary>
        [TestMethod]
        public void IsValidToUpdateProfileTestNull()
        {
            PictureBox picture = new PictureBox();
            bool isValid = ValidatorUtils.IsValidToUpdateProfile("123456", "123456", picture);
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Test IsValidToAddNew method
        /// Test with valid parameter
        /// </summary>
        [TestMethod]
        public void IsValidToAddNewTestIsGood()
        {
            Connection connection = new Connection();
            bool isValid = ValidatorUtils.IsValidToAddNew("newUser", "123456", "123456", ref connection);
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// Test IsValidToAddNew method
        /// Test with not valid parameter
        /// </summary>
        [TestMethod]
        public void IsValidToAddNewTestWithAlreadyTakenName()
        {
            Connection connection = new Connection();
            bool isValid = ValidatorUtils.IsValidToAddNew("test", "123456", "123456", ref connection);
            Assert.IsFalse(isValid);
        }
    }
}