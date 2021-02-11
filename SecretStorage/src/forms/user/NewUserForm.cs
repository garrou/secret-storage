using SecretStorage.src.models;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.user
{
    /// <summary>
    /// User create an account form
    /// </summary>
    public partial class NewUserForm : Form
    {
        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;

        /// <summary>
        /// Init a new form
        /// </summary>
        public NewUserForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        /// <summary>
        /// When user clicks on create account
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void CreateBtn_Click(object sender, EventArgs e)
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
                MessageBox.Show("Compte correctement créé.",
                                "Compte créé",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Impossible de créer votre compte. "
                                + "Le nom doit être unique, le nom et le mot de passe "
                                + "doivent contenir plus de "
                                + Properties.Settings.Default.AuthMinSize,
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                NameTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
        }

        /// <summary>
        /// When user closes form
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void NewUserForm_Closed(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        /// <summary>
        /// When form load
        /// </summary>
        /// <param name="sender">NewUserForm</param>
        /// <param name="e"></param>
        private void NewUserForm_Load(object sender, EventArgs e)
        {
            // Set focus on textfield name
            ActiveControl = NameTextBox;
        }
    }
}
