using SecretStorage.src.models;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms
{
    /// <summary>
    /// LoginForm controller
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Connection to database
        /// </summary>
        private readonly Connection connection;
        
        /// <summary>
        /// Init login form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        /// <summary>
        /// When user clicks on connection button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string name = NameTextField.Text;
            string password = PasswordTextField.Text;

            if (name.Length > 0 && password.Length > 0)
            {
                User authUser = connection.Authentification(name, password);

                if (authUser != null)
                {
                    Hide();
                    if (authUser.IsAdmin)
                    {
                        AdminForm adminForm = new AdminForm(authUser);
                        adminForm.Show();
                    }
                    else
                    {
                        UserForm userForm = new UserForm(authUser);
                        userForm.Show();
                    }
                }
                else
                {
                    ErrorLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// When login form load
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.LoginForm</param>
        /// <param name="e">System.EventArgs</param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set focus on textfield name
            ActiveControl = NameTextField;
        }
    }
}
