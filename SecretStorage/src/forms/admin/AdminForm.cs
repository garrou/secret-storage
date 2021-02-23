using SecretStorage.src.forms.admin;
using SecretStorage.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SecretStorage.src.forms
{
    /// <summary>
    /// Represent admin form
    /// </summary>
    public partial class AdminForm : Form
    {
        #region Properties

        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;

        /// <summary>
        /// Current authentified admin
        /// </summary>
        private User authentifiedAdmin;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Init admin form
        /// </summary>
        public AdminForm(ref User authAdmin)
        {
            InitializeComponent();
            connection = new Connection();
            authentifiedAdmin = authAdmin;
        }

        #endregion Constructor

        #region Events

        /// <summary>
        /// When admin form load
        /// </summary>
        /// <param name="sender">AdminForm</param>
        /// <param name="e">System.EventArgs</param>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Put user informations on admin page
            NameLabel.Text += authentifiedAdmin.Name;

            if (authentifiedAdmin.ProfilePicture != null)
            {
                ProfilePicture.Image = authentifiedAdmin.ProfilePicture;
            }

            LastConnectionLabel.Text += authentifiedAdmin.Logs;
            UsersLabel.Text += connection.CountUsers();

            AddUsersInListView();
        }

        /// <summary>
        /// When admin clicks on disconnect button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        /// <see cref="AdminForm_Closing(object, CancelEventArgs)"/>
        private void Disconnect_Click(object sender, EventArgs e)
        {
            // Call the AdminForm_Closing method
            Close();
        }

        /// <summary>
        /// When admin clicks on red cross
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.AdminForm</param>
        /// <param name="e">System.Windows.Forms.FormClosingEventArgs</param>
        private void AdminForm_Closing(object sender, CancelEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Voulez-vous quitter la page administrateur ?", "Quitter ?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.UpdateLogs(authentifiedAdmin.Id);
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
        /// When admin clicks on add user button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        /// <summary>
        /// When admin clicks on update profile
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdatProfileBtn_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateAdminForm updateAdminForm = new UpdateAdminForm(ref authentifiedAdmin);
            updateAdminForm.Show();
        }

        /// <summary>
        /// When admin clicks on update login page
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateLoginPageBtn_Click(object sender, EventArgs e)
        {
            UpdateLoginForm updateLoginForm = new UpdateLoginForm();
            updateLoginForm.Show();
        }

        /// <summary>
        /// When admins click on update users page
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm();
            updateUserForm.Show();
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Add users in user list view
        /// </summary>
        private void AddUsersInListView()
        {
            List<User> users = connection.GetUsers();
            UserListView.View = View.Details;

            foreach (User user in users)
            {
                UserListView.Items.Add(new ListViewItem(new[] { user.Id.ToString(), user.Name }));
            }
        }

        #endregion Methods
    }
}