using SecretStorage.src.models;
using SecretStorage.src.utils;
using System;
using System.Windows.Forms;

namespace SecretStorage.src.forms.admin
{
    public partial class UpdateAdminForm : Form
    {

        private readonly Connection connection;

        private readonly User authentifiedAdmin;

        public UpdateAdminForm(User admin)
        {
            InitializeComponent();
            connection = new Connection();
            authentifiedAdmin = admin;
        }

        /// <summary>
        /// When user clicks on BtnAddImage
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void UpdateProfileBtn_Click(object sender, EventArgs e)
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
    }
}
