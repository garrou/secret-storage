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

            if (name.Length > Properties.Settings.Default.NameMinSize 
                && password.Length > Properties.Settings.Default.PassMinSize)
            {
                if (password.CompareTo(confPassword) == 0)
                {
                    bool isUnique = connection.CheckIfNameIsUnique(name);

                    if (isUnique && connection.InsertNewUser(name, password) == 1)
                    {
                        MessageBox.Show("L'utilisateur correctement ajouté.",
                                        "Utilisateur créé",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur doit être unique.",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas.",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show($"Le nom d'utilisateur doit contenir plus de {Properties.Settings.Default.NameMinSize} caractères"
                                + $", le mot de passe doit contenir plus de {Properties.Settings.Default.PassMinSize} caractères.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
