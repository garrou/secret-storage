using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.admin
{
    /// <summary>
    /// Form to update admin
    /// </summary>
    public partial class UpdateAdminForm : Form
    {
        /// <summary>
        /// Connection to database
        /// </summary>
        private Connection connection;

        /// <summary>
        /// Current admin
        /// </summary>
        private User authentifiedAdmin;

        /// <summary>
        /// Init UpdateAdminForm 
        /// </summary>
        /// <param name="admin">User admin</param>
        public UpdateAdminForm(ref User admin)
        {
            InitializeComponent();
            connection = new Connection();
            authentifiedAdmin = admin;
        }

        /// <summary>
        /// When user clicks on BtnAddImage
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            UpdateUtils.DialogPicture(ProfilePicture);
        }

        /// <summary>
        /// When admin save modifications
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UpdateUtils.Updater(PasswordTextBox.Text, ConfirmPassTextBox.Text, ref authentifiedAdmin, ProfilePicture, ref connection))
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
        /// <param name="sender">AdminForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UpdateAdminForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = authentifiedAdmin.Name;

            if (authentifiedAdmin.ProfilePicture != null)
            {
                ProfilePicture.Image = authentifiedAdmin.ProfilePicture;
            }
        }

        /// <summary>
        /// When form closed
        /// </summary>
        /// <param name="sender">UpdateAdminForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UpdateAdminForm_Closed(object sender, EventArgs e)
        {
            // Refresh the admin
            connection.RefreshCurrentUser(ref authentifiedAdmin);
            connection.Close();
            AdminForm adminForm = new AdminForm(ref authentifiedAdmin);
            adminForm.Show();
        }
    }
}
