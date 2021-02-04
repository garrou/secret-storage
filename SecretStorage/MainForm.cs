using System;
using System.Windows.Forms;

namespace SecretStorage
{
    /// <summary>
    /// Class with buttons events
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Application
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region Numbers events

        /// <summary>
        /// When user click on the number 0
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 0;
        }

        /// <summary>
        /// When user click on the number 1
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void OneBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 1;
        }

        /// <summary>
        /// When user click on the number 2
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 2;
        }

        /// <summary>
        /// When user click on the number 3
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 3;
        }

        /// <summary>
        /// When user click on the number 4
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void FourBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 4;
        }

        /// <summary>
        /// When user click on the number 5
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 5;
        }

        /// <summary>
        /// When user click on the number 6
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SixBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 6;
        }

        /// <summary>
        /// When user click on the number 7
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 7;
        }

        /// <summary>
        /// When user click on the number 8
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EightBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 8;
        }

        /// <summary>
        /// When user click on the number 9
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void NineBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += 9;
        }

        #endregion Numbers events

        #region Symbols events

        /// <summary>
        /// When user click on the number "+/-"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void NegativeBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text = (-1 * Int64.Parse(this.ComputeTextBox.Text)).ToString();
        }

        /// <summary>
        /// When user click on the number ","
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void CommaBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += ".";
        }

        /// <summary>
        /// When user click on the number "="
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EqualBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When user click on the number "+"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// When user click on the number "-"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// When user click on the number "x"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void MultBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When user click on the number "/"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void DivBtn_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// When user click on the number "CE"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text = "0";
        }

        /// <summary>
        /// When user click on the number "%"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text += "%";
        }

        /// <summary>
        /// When user click on the number "<"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EraseBtn_Click(object sender, EventArgs e)
        {
            this.ComputeTextBox.Text = this.ComputeTextBox.Text.Remove(this.ComputeTextBox.TextLength - 1);
        }

        #endregion Symbols regions

        #region TextBox events

        /// <summary>
        /// When a 0 is in text box and user input an other number
        /// Consist in replacement of 0 with the clicked number
        /// </summary>
        /// <param name="sender">System.Windows.Forms.TextBox</param>
        /// <param name="e">System.EventArgs</param>
        private void ComputeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ComputeTextBox.TextLength == 2 && this.ComputeTextBox.Text[0] == '0')
            {
                Console.WriteLine(e.GetType());
                this.ComputeTextBox.Text = this.ComputeTextBox.Text.Remove(0, 1);
            }
        }

        #endregion TextBox events
    }
}
