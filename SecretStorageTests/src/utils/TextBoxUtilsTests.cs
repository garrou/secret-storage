using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test TextBoxUtils class
    /// </summary>
    [TestClass()]
    public class TextBoxUtilsTests
    {
        /// <summary>
        /// Test Put method
        /// Add content in the string
        /// </summary>
        [TestMethod()]
        public void PutTestAdd()
        {
            int cursorPosition = 2;
            string result = TextBoxUtils.Put("Current content", ref cursorPosition, "98");
            Assert.AreEqual(result.CompareTo("Cu98rrent content"), 0);
        }

        /// <summary>
        /// Test Put method
        /// Add content at begin
        /// </summary>
        [TestMethod()]
        public void PutTestAddAtBegin()
        {
            int cursorPosition = 0;
            string result = TextBoxUtils.Put("Current content", ref cursorPosition, "98");
            Assert.AreEqual(result.CompareTo("98Current content"), 0);
        }

        /// <summary>
        /// Test Put method
        /// Add content at the end 
        /// </summary>
        [TestMethod()]
        public void PutTestAddAtEnd()
        {
            int cursorPosition = 15;
            string result = TextBoxUtils.Put("Current content", ref cursorPosition, "98");
            Assert.AreEqual(result.CompareTo("Current content98"), 0);
        }

        /// <summary>
        /// Test Put method
        /// Add content outside
        /// </summary>
        [TestMethod()]
        public void PutTestAddOutside()
        {
            int cursorPosition = 20;
            string result = TextBoxUtils.Put("Current content", ref cursorPosition, "98");
            Assert.AreEqual(result.CompareTo("Current content98"), 0);
        }

        /// <summary>
        /// Test Put method
        /// Add at negative position
        /// </summary>
        [TestMethod()]
        public void PutTestAddAtNegativePosition()
        {
            int cursorPosition = -8;
            string result = TextBoxUtils.Put("Current content", ref cursorPosition, "98");
            Assert.AreEqual(result.CompareTo("Current content98"), 0);
        }
    }
}