using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretStorage.src.forms.admin
{
    /// <summary>
    /// Controller class of UpdateUserForm
    /// </summary>
    public partial class UpdateUserForm : Form
    {
        #region Properties

        /// <summary>
        /// Database connection
        /// </summary>
        private Connection connection;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Init an UpdateUserForm
        /// </summary>
        public UpdateUserForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Add users in user list view
        /// </summary>
        private void AddUsersInListView()
        {
            List<User> users = connection.GetUsers();
            UsersListView.View = View.Details;

            foreach (User user in users)
            {
                UsersListView.Items.Add(new ListViewItem(new[] { user.Id.ToString(), user.Name }));
            }
        }

        /// <summary>
        /// Add users id in combo box
        /// </summary>
        private void AddUserIdInComboBox()
        {
            List<string> usersId = connection.GetUsersId();

            foreach (string id in usersId)
            {
                ComboBoxId.Items.Add(id);
            }
        }

        #endregion Methods

        #region Events

        /// <summary>
        /// UpdateUserForm load
        /// </summary>
        /// <param name="sender">UpdateUserForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            AddUsersInListView();
            AddUserIdInComboBox();
        }

        /// <summary>
        /// When admin clicks on valid button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ValidBtn_Click(object sender, EventArgs e)
        {
            if (StatusLabel.Text.IndexOf("Suppression") != -1)
            {
                UpdateUtils.DeleteUser(ComboBoxId.SelectedItem.ToString(), ref connection);
            } 
            else if (StatusLabel.Text.IndexOf("Modification") != -1)
            {
                UpdateUtils.UpdatePassword(ComboBoxId.SelectedItem.ToString(), PassTextBox.Text, ConfPassTextBox.Text, ref connection);
            }
            else
            {
                MessageBox.Show("Choisissez une action : \n-Suppression\n-Modification", "Choisir une action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UsersListView.Items.Clear();
            AddUsersInListView();
        }

        /// <summary>
        /// When admin clicks on update button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Action : Modification";
            PassTextBox.Enabled = true;
            ConfPassTextBox.Enabled = true;
            ValidBtn.Enabled = true;
        }

        /// <summary>
        /// When admin clicks on delete button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Action : Suppression";
            PassTextBox.Enabled = false;
            ConfPassTextBox.Enabled = false;
            ValidBtn.Enabled = true;
        }

        #endregion Events
    }
}
