using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test AnalyseUtils class
    /// </summary>
    [TestClass]
    public class AnalyseTests
    {
        /// <summary>
        /// Test AnalyseAndReplace method with 'x'
        /// Uses IndexOf
        /// </summary>
        [TestMethod]
        public void AnalyseAndReplaceTestWithIndexOfX()
        {
            string toAnalyse = "This x is a string to test x char like xxx";
            string result = AnalyseUtils.AnalyseAndReplace(toAnalyse);
            Assert.AreEqual(result.IndexOf('x'), -1);
        }

        /// <summary>
        /// Test AnalyseAndReplace method with 'x'
        /// Uses CompareTo
        /// </summary>
        [TestMethod]
        public void AnalyseAndReplaceTestWithCompareToX()
        {
            string toAnalyse = "This x is a string to test x char like xxx";
            string result = AnalyseUtils.AnalyseAndReplace(toAnalyse);
            Assert.AreEqual(result.CompareTo("This * is a string to test * char like ***"), 0);   
        }

        /// <summary>
        /// Test AnalyseAndReplace method with ','
        /// Uses IndexOf
        /// </summary>
        [TestMethod]
        public void AnalyseAndReplaceTestWithIndexOfComma()
        {
            string toAnalyse = "This , is a string to test , char like ,,,";
            string result = AnalyseUtils.AnalyseAndReplace(toAnalyse);
            Assert.AreEqual(result.IndexOf(','), -1);
        }

        /// <summary>
        /// Test AnalyseAndReplace method with ','
        /// Uses CompareTo
        /// </summary>
        [TestMethod]
        public void AnalyseAndReplaceTestWithCompareToComma()
        {
            string toAnalyse = "This , is a string to test , char like ,,,";
            string result = AnalyseUtils.AnalyseAndReplace(toAnalyse);
            Assert.AreEqual(result.CompareTo("This . is a string to test . char like ..."), 0);
        }
    }
}