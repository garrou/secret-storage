using SecretStorage.src.models;
using SecretStorage.src.utils;
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

        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;

        public UserForm(User authUser)
        {
            InitializeComponent();
            authentifiedUser = authUser;
            connection = new Connection();
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
                    ProfilePicture.ImageLocation = fileDialog.FileName;
                    
                    // connection.UpdateProfilePicture(encoded, authentifiedUser.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}