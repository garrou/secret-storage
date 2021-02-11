namespace SecretStorage.src.utils
{
    /// <summary>
    /// AnalyseUtils class 
    /// </summary>
    public static class AnalyseUtils
    {
        /// <summary>
        /// AnalyseUtils a string and replace 'x' by '*'
        /// and ',' by '.' to compute the result
        /// </summary>
        /// <param name="toBeAnalysed">String to be analysed</param>
        /// <returns>A well formatted string to compute</returns>
        public static string AnalyseAndReplace(string toBeAnalysed)
        {
            string result = "";

            foreach(char value in toBeAnalysed)
            {
                if (value == 'x')
                {
                    result += '*';
                } 
                else if (value == ',')
                {
                    result += '.';
                }
                else
                {
                    result += value;
                }
            }

            return result;
        }
    }
}
