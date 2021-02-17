using SecretStorage.src.forms.user;
using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SecretStorage.src.forms
{
    /// <summary>
    /// UserForm controller
    /// </summary>
    public partial class UserForm : Form
    {
        /// <summary>
        /// The current authenfied user
        /// </summary>
        private User authentifiedUser;

        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;

        public UserForm(ref User authUser)
        {
            InitializeComponent();
            authentifiedUser = authUser;
            connection = new Connection();
        }

        /// <summary>
        /// When UserForm loaded
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.UserForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UserForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text += authentifiedUser.Name;

            if (!connection.IsDefaultImage(authentifiedUser.Id))
            {
                // Retrieve profile picture from database
                byte[] image = connection.GetEncodedProfilPicture(authentifiedUser.Id);

                // Set the image
                ProfilePicture.Image = ImageUtils.FromBytesToImage(image);
            }
            // else do nothing and use default image

            LastConnectionLabel.Text += connection.GetLogs(authentifiedUser.Id);

            AddPasswordsInListView();
        }

        /// <summary>
        /// Add users in user list view
        /// </summary>
        private void AddPasswordsInListView()
        {
            List<Secret> secretPass = connection.GetAllUserSecretPasswords(authentifiedUser.Id);
            PasswordListView.View = View.Details;

            foreach (Secret secret in secretPass)
            {
                PasswordListView.Items.Add(new ListViewItem(new[] { secret.Name, secret.Password }));
            }
        }

        /// <summary>
        /// When user clicks on disconnect button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        /// <see cref="UserForm_Closing(object, CancelEventArgs)"/>
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            // Call the UserForm_Closing method
            Close();
        }

        /// <summary>
        /// When user clicks on BtnAddImage
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateUserForm updateUserForm = new UpdateUserForm(ref authentifiedUser);
            updateUserForm.Show();
        }

        /// <summary>
        /// When user clicks on red cross
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.UserForm</param>
        /// <param name="e">System.Windows.Forms.FormClosingEventArgs</param>
        private void UserForm_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter la page ?", "Quitter ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.UpdateLogs(authentifiedUser.Id);
                connection.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// When user clicks on button add secret
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void BtnAddPassword_Click(object sender, EventArgs e)
        {
            Hide();
            AddPasswordForm addPasswordForm = new AddPasswordForm(authentifiedUser);
            addPasswordForm.Show();
        }
    }
}