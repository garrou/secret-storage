using SecretStorage.src.models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretStorage.src.forms
{
    /// <summary>
    /// Represent admin form
    /// </summary>
    public partial class AdminForm : Form
    {
        /// <summary>
        /// Database connection
        /// </summary>
        private readonly Connection connection;

        /// <summary>
        /// Init admin form
        /// </summary>
        public AdminForm()
        {
            InitializeComponent();
            connection = new Connection();
        }

        /// <summary>
        /// When admin click to execute button
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SqlButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Execute(SqlTextBox.Text);
                SqlTextBox.Text = "";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// When admin form load
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.AdminForm</param>
        /// <param name="e">System.EventArgs</param>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            List<User> users = connection.GetAllUsers();

            UserListView.View = View.Details;
            UserListView.GridLines = true;

            foreach (User user in users)
            {
                UserListView.Items.Add(new ListViewItem(new string[] { user.Id.ToString(), user.Name, user.Password }));
            }
        }

        /// <summary>
        /// Hide the admin form and display the calculator form
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void Disconnect_Click(object sender, EventArgs e)
        {
            Hide();
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }
    }
}
