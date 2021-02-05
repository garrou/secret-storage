using System;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// Utils class to apply on ComputedTextBox
    /// </summary>
    public static class TextBoxUtils
    {
        /// <summary>
        /// Put a number in ComputedTextBox
        /// </summary>
        /// <param name="textBoxContent">Current content on ComputedTextBox</param>
        /// <param name="currentCursorPos">Current cursor position</param>
        /// <param name="toAdd">Number to add in ComputedTextBox</param>
        /// <returns></returns>
        public static string Put(string textBoxContent, ref int currentCursorPos, string toAdd)
        {
            if (currentCursorPos >= 0 && currentCursorPos <= textBoxContent.Length)
            {
                textBoxContent = textBoxContent.Insert(currentCursorPos, toAdd);
                currentCursorPos++;
            }
            else
            {
                textBoxContent += toAdd;
            }

            return textBoxContent;
        }
    }
}
