using SecretStorage.src.models;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// UpdateUtils class
    /// </summary>
    public class UpdateUtils
    {
        /// <summary>
        /// Update profile picture of user
        /// </summary>
        /// <param name="imageContainer">PictureBox who contains image</param>
        /// <param name="connection">Database connection</param>
        /// <param name="userId">User unique id</param>
        public static void UpdateProfilePicture(PictureBox imageContainer, Connection connection, uint userId)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png"
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    byte[] bytes = ImageUtils.FromFileNameToBytes(fileName);

                    // Update profile picture in database
                    connection.UpdateProfilePicture(bytes, userId);

                    // Set the image
                    imageContainer.ImageLocation = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update user name and password
        /// </summary>
        /// <param name="name">New user name</param>
        /// <param name="password">New user password</param>
        /// <param name="confPass">User confirmation password</param>
        /// <param name="userId">User unique id</param>
        /// <param name="connection">Database connection</param>
        public static bool UpdateNamePassword(string name, 
                                              string password, 
                                              string confPass, 
                                              uint userId, 
                                              Connection connection) 
        {
            bool isUpdated = false;

            if (name.Length > Properties.Settings.Default.NameMinSize 
                && password.Length > Properties.Settings.Default.PassMinSize
                && password.CompareTo(confPass) == 0
                && connection.CheckIfNameIsUnique(name)) {

                connection.UpdateNamePassword(name, password, userId);
                isUpdated = true;
            }

            return isUpdated;
        }
    }
}
