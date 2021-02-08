using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test Analyse class
    /// </summary>
    [TestClass()]
    public class AnalyseTests
    {
        /// <summary>
        /// Test AnalyseAndReplace method
        /// </summary>
        [TestMethod()]
        public void AnalyseAndReplaceTest()
        {
            string toAnalyse = "This, is a string to test x char like x,x,";
            string result = Analyse.AnalyseAndReplace(toAnalyse);

            if (result.IndexOf('x') != -1 || result.IndexOf('x') != -1)
            {
                Assert.Fail();
            }
        }
    }
}