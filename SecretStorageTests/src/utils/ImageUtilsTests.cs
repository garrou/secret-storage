using SecretStorage.src.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test ImageUtils class
    /// </summary>
    [TestClass]
    public class ImageUtilsTests
    {
        /// <summary>
        /// Image path used during tests
        /// </summary>
        private readonly string Filename = "../../assets/cs.png";

        /// <summary>
        /// Test FromFileNameToBytes method
        /// Test if this method return not null
        /// if image path is valid
        /// </summary>
        [TestMethod]
        public void FromFileNameToBytesTestWithValidFilePath()
        {
            byte[] encodedImage = ImageUtils.FromFileNameToBytes(Filename);
            Assert.IsNotNull(encodedImage);
        }

        /// <summary>
        /// Test FromFileNameToBytes method
        /// Test behaviour method if file path is incorrect
        /// </summary>
        [TestMethod]
        public void FromFileNameToBytesTestWithInvalidFilePath()
        {
            byte[] encodedImage = ImageUtils.FromFileNameToBytes("");
            Assert.IsNull(encodedImage);
        }

        /// <summary>
        /// Test FromBytesToImage method
        /// Test with a valid image
        /// </summary>
        [TestMethod]
        public void FromBytesToImageTestWithValidImage()
        {
            byte[] encodedImage = ImageUtils.FromFileNameToBytes(Filename);
            Image image = ImageUtils.FromBytesToImage(encodedImage);
            Assert.IsNotNull(image);
        }

        /// <summary>
        /// Test FromBytesToImage method
        /// Test with null image
        /// </summary>
        [TestMethod]
        public void FromBytesToImageTestWithNullImage()
        {
            Image image = ImageUtils.FromBytesToImage(null);
            Assert.IsNull(image);
        }

        /// <summary>
        /// Test FromImageBytes method
        /// Test with null image
        /// </summary>
        [TestMethod]
        public void FromImageToBytesTestImageNull()
        {
            byte[] bytes = ImageUtils.FromImageToBytes(null);
            Assert.IsNull(bytes);
        }

        /// <summary>
        /// Test FromImageBytes method
        /// Test with an existing image
        /// </summary>
        [TestMethod]
        public void FromImageToBytesTestImageExists()
        {
            byte[] bytes = ImageUtils.FromImageToBytes(new Bitmap("../../assets/cs.png"));
            Assert.IsNotNull(bytes);
        }
    }
}