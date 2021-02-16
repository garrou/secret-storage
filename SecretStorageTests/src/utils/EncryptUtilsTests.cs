using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test class EncryptUtils
    /// </summary>
    [TestClass]
    public class EncryptUtilsTests
    {
        /// <summary>
        /// Test Encrypt method
        /// </summary>
        [TestMethod]
        public void EncryptTest()
        {
            string toEncrypt = "123456";
            string encrypted = EncryptUtils.Encrypt(toEncrypt);
            Assert.AreNotEqual(toEncrypt, encrypted);
        }
    }
}