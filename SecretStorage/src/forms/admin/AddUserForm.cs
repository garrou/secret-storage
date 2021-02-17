using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.admin
{
    /// <summary>
    /// AddUserForm controller
    /// </summary>
    public partial class AddUserForm : Form
    {
        /// <summary>
        /// Connection to database
        /// </summary>
        private Connection connection;

        /// <summary>
        /// Init a new AddUserForm
        /// </summary>
        public AddUserForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        /// <summary>
        /// When admin clicks on add button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ValidatorUtils.IsValidToAddNew(NameTextBox.Text, PasswordTextBox.Text, ConfirmPassTextBox.Text, ref connection)
                && connection.InsertNewUser(NameTextBox.Text, PasswordTextBox.Text) == 1
                && connection.InsertNewImage(NameTextBox.Text, PasswordTextBox.Text) == 1
                && connection.InsertNewLog(NameTextBox.Text, PasswordTextBox.Text) == 1) 
            {
                MessageBox.Show("L'utilisateur correctement ajouté.",
                                "Utilisateur créé",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Impossible de créer l'utilisateur.\n"
                                + "Le nom doit être unique, le nom et le mot de passe "
                                + "doivent contenir plus de " 
                                + Properties.Settings.Default.AuthMinSize,
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
