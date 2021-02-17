using SecretStorage.src.models;
using System.Windows.Forms;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// Validator class 
    /// Validate data
    /// </summary>
    public class ValidatorUtils
    {
        /// <summary>
        /// Check several constraints on password
        /// - Same
        /// - Size > 3
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confPassword"></param>
        /// <returns></returns>
        public static bool IsValidToUpdatePassword(string password, string confPassword)
        {
            return password.Trim().Length > Properties.Settings.Default.AuthMinSize
                   && confPassword.Trim().Length > Properties.Settings.Default.AuthMinSize
                   && password.Trim().CompareTo(confPassword.Trim()) == 0;
        }

        /// <summary>
        /// Check several constraints on password and PictureBox
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confPassword"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        public static bool IsValidToUpdateProfile(string password, string confPassword, PictureBox container)
        {
            return password.Trim().Length > Properties.Settings.Default.AuthMinSize
                   && confPassword.Trim().Length > Properties.Settings.Default.AuthMinSize
                   && password.Trim().CompareTo(confPassword.Trim()) == 0
                   && container.ImageLocation != null;
        }

        /// <summary>
        /// Check if name, password and confPassword
        /// are correct
        /// </summary>
        /// <param name="name">New user name</param>
        /// <param name="password">New user password/param>
        /// <param name="confPassword">User confirmation password</param>
        /// <returns></returns>
        public static bool IsValidToAddNew(string name, string password, string confPassword, ref Connection connection)
        {
            return name.Trim().Length > Properties.Settings.Default.AuthMinSize
                    && IsValidToUpdatePassword(password, confPassword)
                    && connection.CheckIfNameIsUnique(name.Trim());
        }
    }
}
