using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.user
{
    /// <summary>
    /// UpdateUserForm controller
    /// </summary>
    public partial class UpdateUserForm : Form
    {
        /// <summary>
        /// Database connection
        /// </summary>
        private Connection connection;

        /// <summary>
        /// Authentified user
        /// </summary>
        private User authentifiedUser;

        /// <summary>
        /// Init an UpdateUserForm
        /// </summary>
        public UpdateUserForm(ref User user)
        {
            InitializeComponent();
            connection = new Connection();
            authentifiedUser = user;
        }

        /// <summary>
        /// When user clicks on update profil picture
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateProfilePictureBtn_Click(object sender, EventArgs e)
        {
            UpdateUtils.DialogPicture(ProfilePicture);
        }

        /// <summary>
        /// When user clicks on update profile button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UpdateUtils.Updater(PasswordTextBox.Text, ConfirmPassTextBox.Text, ref authentifiedUser, ProfilePicture, ref connection))
            {
                // Call form closed method
                Close();
            }
            else
            {
                PasswordTextBox.Text = "";
                ConfirmPassTextBox.Text = "";
            }
        }

        /// <summary>
        /// When form load
        /// </summary>
        /// <param name="sender">UpdateUserForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = authentifiedUser.Name;

            if (authentifiedUser.ProfilePicture != null)
            {
                ProfilePicture.Image = authentifiedUser.ProfilePicture;
            }
        }

        /// <summary>
        /// When form closed
        /// </summary>
        /// <param name="sender">UpdateUserForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UpdateUserForm_Closed(object sender, EventArgs e)
        {
            // Refresh the user
            connection.RefreshCurrentUser(ref authentifiedUser);
            connection.Close();
            UserForm userForm = new UserForm(ref authentifiedUser);
            userForm.Show();
        }
    }
}
