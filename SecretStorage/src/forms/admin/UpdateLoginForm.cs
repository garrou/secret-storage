using SecretStorage.src.models;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.admin
{
    /// <summary>
    /// UPdateLoginForm controller
    /// </summary>
    public partial class UpdateLoginForm : Form
    {
        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;
        
        /// <summary>
        /// Init form
        /// </summary>
        public UpdateLoginForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        /// <summary>
        /// When user clicks on update button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            string confPassword = ConfirmPassTextBox.Text;

            if (password.Length > Properties.Settings.Default.AuthMinSize
                && password.CompareTo(confPassword) == 0)
            {
                if (connection.UpdateLoginPassword(password))
                {
                    MessageBox.Show("Mot de passe modifié avec succés.",
                                "Mot de passe modifié",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur durant la modification du mot de passe.",
                                    "Impossible de modifier le mot de passe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Erreur durant la modification du mot de passe.",
                                "Impossible de modifier le mot de passe",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
