using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.user
{
    /// <summary>
    /// AddPasswordForm controller
    /// </summary>
    public partial class AddPasswordForm : Form
    {
        /// <summary>
        /// Database connection
        /// </summary>
        private Connection connection;

        /// <summary>
        /// Current authentifiedUser
        /// </summary>
        private User authentifiedUser;

        /// <summary>
        /// Init a AddPasswordForm
        /// </summary>
        public AddPasswordForm(User user)
        {
            InitializeComponent();
            connection = new Connection();
            authentifiedUser = user;
        }

        /// <summary>
        /// When user clicks on save secret
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ValidatorUtils.IsValidToAddNew(NameTextBox.Text, PasswordTextBox.Text, ConfirmPassTextBox.Text, ref connection)
                && connection.AddNewSecretPassword(authentifiedUser.Id, NameTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("Secret ajouté avec succés.", "Secret ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter le secret.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PasswordTextBox.Text = "";
            ConfirmPassTextBox.Text = "";
        }

        /// <summary>
        /// When form closed
        /// </summary>
        /// <param name="sender">UpdateUserForm</param>
        /// <param name="e">System.EventArgs</param>
        private void AddPasswordForm_Closed(object sender, EventArgs e)
        {
            connection.Close();
            UserForm userForm = new UserForm(ref authentifiedUser);
            userForm.Show();
        }
    }
}
