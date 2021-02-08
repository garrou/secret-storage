using SecretStorage.src.models;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms
{
    /// <summary>
    /// UserForm controller
    /// </summary>
    public partial class UserForm : Form
    {
        /// <summary>
        /// The current authenfied user
        /// </summary>
        private readonly User authentifiedUser;

        public UserForm(User authUser)
        { 
            InitializeComponent();
            authentifiedUser = authUser;
        }

        /// <summary>
        /// When UserForm loaded
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.UserForm</param>
        /// <param name="e">System.EventArgs</param>
        private void UserForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text += authentifiedUser.Name;
        }

        /// <summary>
        /// When user clicks on disconnect button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }
    }
}
