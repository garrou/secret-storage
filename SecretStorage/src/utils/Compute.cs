using System.Data;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// Class to make calculation
    /// </summary>
    public class Compute
    {
        /// <summary>
        /// Make the calculation
        /// </summary>
        /// <param name="toCalculate">String to compute</param>
        /// <returns>The result of the operation</returns>
        public static string DoTheMath(string toCalculate)
        {
            DataTable dt = new DataTable();
            object result = dt.Compute(toCalculate, "");

            return result.ToString();
        }
    }
}
