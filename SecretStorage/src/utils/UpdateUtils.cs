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
        public static void UpdateProfilePicture(PictureBox imageContainer)
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
                    imageContainer.ImageLocation = fileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de modifier la photo de profil.", 
                                "Erreur", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update user name and password
        /// </summary>
        /// <param name="password">New user password</param>
        /// <param name="confPass">User confirmation password</param>
        /// <param name="userId">User unique id</param>
        /// <param name="connection">Database connection</param>
        public static bool UpdateProfile(string password, 
                                         string confPass, 
                                         ref User user,
                                         PictureBox container,
                                         Connection connection) 
        {
            bool isUpdated = false;
            byte[] bytes;

            if (password.Length > Properties.Settings.Default.AuthMinSize
                && password.CompareTo(confPass) == 0) {

                bytes = ImageUtils.FromFileNameToBytes(container.ImageLocation);

                // If user don't update his profile picture
                if (bytes == null)
                {
                    bytes = ImageUtils.FromImageToBytes(user.ProfilePicture);
                }

                connection.UpdateProfilePicture(bytes, user.Id);
                connection.UpdatePassword(password, user.Id);
                isUpdated = true;
            }

            return isUpdated;
        }
    }
}
