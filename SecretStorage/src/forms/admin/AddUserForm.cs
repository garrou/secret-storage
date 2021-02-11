using SecretStorage.src.models;
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
        private readonly Connection connection;

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
            string name = NameTextBox.Text;
            string password = PasswordTextBox.Text;
            string confPassword = ConfirmPassTextBox.Text;            

            if (name.Length > Properties.Settings.Default.AuthMinSize 
                && password.Length > Properties.Settings.Default.AuthMinSize
                && password.CompareTo(confPassword) == 0 
                && connection.CheckIfNameIsUnique(name)
                && connection.InsertNewUser(name, password) == 1
                && connection.InsertNewImage(name, password) == 1
                && connection.InsertNewLog(name, password) == 1) 
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
