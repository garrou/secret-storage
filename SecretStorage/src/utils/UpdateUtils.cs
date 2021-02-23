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
        public static void DialogPicture(PictureBox imageContainer)
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
                MessageBox.Show("Impossible d'afficher les images.", 
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
        private static bool UpdateProfile(string password, string confPass, ref User user, PictureBox imageContainer, ref Connection connection)
        {
            bool isUpdated = false;
            byte[] bytes;

            if (password.Length > Properties.Settings.Default.AuthMinSize
                && password.CompareTo(confPass) == 0) {
                
                bytes = ImageUtils.FromFileNameToBytes(imageContainer.ImageLocation);
                
                if (bytes == null)
                {
                    // Get the current profile picture
                    bytes = ImageUtils.FromImageToBytes(user.ProfilePicture);
                }

                connection.UpdateProfilePicture(bytes, user.Id);
                connection.UpdatePassword(password, user.Id);
                isUpdated = true;
            }

            return isUpdated;
        }

        /// <summary>
        /// Update user profile picture
        /// </summary>
        /// <param name="container">Image container</param>
        /// <param name="user">User to ask to update</param>
        private static void UpdateOnlyImage(PictureBox imageContainer, ref User user)
        {
            Connection connection = new Connection();
            byte[] bytes = ImageUtils.FromFileNameToBytes(imageContainer.ImageLocation);

            // If user don't update his profile picture
            if (bytes == null)
            {
                bytes = ImageUtils.FromImageToBytes(user.ProfilePicture);
            }

            connection.UpdateProfilePicture(bytes, user.Id);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="password">Password to set</param>
        /// <param name="confPass">Confirmation pasword</param>
        /// <param name="user">User to update</param>
        /// <param name="imageContainer">PictureBox to display image</param>
        /// <param name="connection">Database connection</param>
        public static bool Updater(string password, string confPass, ref User user, PictureBox imageContainer, ref Connection connection)
        {
            bool updated = false;

            if (ValidatorUtils.IsValidToUpdateProfile(password, confPass, imageContainer))
            {
                UpdateProfile(password, confPass, ref user, imageContainer, ref connection);
                updated = true;
                MessageBox.Show("Profil modifié avec succés.",
                                "Profil modifié",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (ValidatorUtils.IsValidToUpdatePassword(password, confPass))
            {
                connection.UpdatePassword(password, user.Id);
                updated = true;
                MessageBox.Show("Mot de passe modifié avec succés.",
                                "Mot de passe modifié",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (imageContainer.ImageLocation != null)
            {
                UpdateOnlyImage(imageContainer, ref user);
                updated = true;
                MessageBox.Show("Photo de profil modifiée avec succés.",
                                "Photo de profil modifiée",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Impossible de modifier le profil.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return updated;
        }

        /// <summary>
        /// When user delete user
        /// </summary>
        /// <param name="id">User unique id</param>
        /// <param name="connection">Database connection</param>
        public static void DeleteUser(string id, ref Connection connection)
        {
            bool result = true;

            if (ValidatorUtils.IsValidToUpdateUser(id))
            {
                result &= connection.DeleteUser(id)
                        && connection.DeleteUserImage(id)
                        && connection.DeleteUserLogs(id)
                        && connection.DeleteUserPasswords(id);
            }

            if (result)
            {
                MessageBox.Show("Utilisateur supprimé avec succés.", "Utilisateur supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur ! Impossible de supprimer l'utilisateur.", "Erreur durant la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update user name and password
        /// </summary>
        /// <param name="id"></param>
        /// <param name="connection"></param>
        public static void UpdatePassword(string id, string pass, string confPass, ref Connection connection)
        {
            if (ValidatorUtils.IsValidToUpdatePassword(pass, confPass))
            {
                connection.UpdatePassword(pass, uint.Parse(id));
                MessageBox.Show("Mot de passe modifié avec succés.", "Mot de passe modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Erreur ! Impossible de modifier le mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
