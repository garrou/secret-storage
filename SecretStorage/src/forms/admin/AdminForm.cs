using SecretStorage.src.models;
using SecretStorage.src.utils;
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
        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;

        /// <summary>
        /// Current authentified admin
        /// </summary>
        private readonly User authentifiedAdmin;

        /// <summary>
        /// Init admin form
        /// </summary>
        public AdminForm(User authAdmin)
        {
            InitializeComponent();
            connection = new Connection();
            authentifiedAdmin = authAdmin;
        }

        /// <summary>
        /// When admin form load
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.AdminForm</param>
        /// <param name="e">System.EventArgs</param>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            AddInUsersListView();
            NameLabel.Text += authentifiedAdmin.Name;

            if (!connection.IsDefaultImage(authentifiedAdmin.Id))
            {
                // Retrieve profile picture from database
                byte[] image = connection.GetEncodedProfilPicture(authentifiedAdmin.Id);

                // Set the image
                ProfilePicture.Image = ImageUtils.FromBytesToImage(image);
            }
            // else do nothing and use default image

            // Get the last connection user date
            LastConnectionLabel.Text += connection.GetLogs(authentifiedAdmin.Id);

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
        /// Add in users listview
        /// </summary>
        public void AddInUsersListView()
        {
            List<User> users = connection.GetAllUsers();

            UserListView.Items.Clear();
            UserListView.View = View.Details;
            UserListView.GridLines = true;

            foreach (User user in users)
            {
                UserListView.Items.Add(new ListViewItem(new string[] { user.Id.ToString(), user.Name }));
            }
        }

        /// <summary>
        /// When user clicks on BtnAddImage
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Filter = "Image Files(*.bmp;*.jpg;*.gif;*png)|*.bmp;*.jpg;*.gif;*.png"
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    byte[] bytes = ImageUtils.FromFileNameToBytes(fileName);

                    // Update profile picture in database
                    connection.UpdateProfilePicture(bytes, authentifiedAdmin.Id);

                    // Retrieve profile picture from database
                    byte[] image = connection.GetEncodedProfilPicture(authentifiedAdmin.Id);

                    // Set the image
                    ProfilePicture.Image = ImageUtils.FromBytesToImage(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// When admin clicks on red cross
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.AdminForm</param>
        /// <param name="e">System.Windows.Forms.FormClosingEventArgs</param>
        private void AdminForm_Closing(object sender, CancelEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want quit admin page ?", "Admin",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.UpdateLogs(authentifiedAdmin.Id);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            } 
            else
            {
                e.Cancel = true;
            }
        }
    }
}
