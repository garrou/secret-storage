using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test class Compute
    /// </summary>
    [TestClass()]
    public class ComputeTests
    {
        /// <summary>
        /// Test of DoTheMath method
        /// Test with parentheses
        /// </summary>
        [TestMethod()]
        public void DoTheMathTestWithParentheses()
        {
            string result = Compute.DoTheMath("( 5 + 8 ) * 2 + 3 - 2");
            Assert.AreEqual(int.Parse(result), 27);
        }

        /// <summary>
        /// Test of DoTheMath method
        /// Test without parentheses
        /// </summary>
        [TestMethod()]
        public void DoTheMathWithoutParentheses()
        {
            string result = Compute.DoTheMath("5 + 8 * 2 + 3 - 2");
            Assert.AreEqual(int.Parse(result), 22);
        }

        /// <summary>
        /// Test of DoTheMath method
        /// Test with divide
        /// </summary>
        [TestMethod()]
        public void DoTheMathAndDivide()
        {
            string result = Compute.DoTheMath("5 / 5 * 2 + 3 - 2");
            Assert.AreEqual(int.Parse(result), 3);
        }

        /// <summary>
        /// Test of DoTheMath method
        /// Test with square
        /// </summary>
        [TestMethod()]
        public void DoTheMathAndSquare()
        {
            string result = Compute.DoTheMath("5 * 5 + 3");
            Assert.AreEqual(int.Parse(result), 28);
        }

        /// <summary>
        /// Test of DoTheMath method
        /// Test with divide double
        /// </summary>
        [TestMethod()]
        public void DoTheMathAndDivideDouble()
        {
            string result = Compute.DoTheMath("1 / 10 + 1 / 10");
            Assert.AreEqual(double.Parse(result), 0.20);
        }

        /// <summary>
        /// Test of DoTheMath method
        /// Test with multiplication numbers
        /// </summary>
        [TestMethod()]
        public void DoTheMathAndMultDouble()
        {
            string result = Compute.DoTheMath("1.5 * 10 + 2.5 * 10");
            Assert.AreEqual(double.Parse(result), 40);
        }
    }
}