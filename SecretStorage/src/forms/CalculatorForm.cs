using SecretStorage.src.utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace SecretStorage
{
    /// <summary>
    /// Class with buttons events
    /// </summary>
    public partial class CalculatorForm : Form
    {

        #region Fields

        private int position;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Application
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
            position = -1;
        }

        #endregion Constructor

        #region Numbers events

        /// <summary>
        /// When user click on the number 0
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "0");
        }

        /// <summary>
        /// When user click on the number 1
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void OneBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "1");
        }

        /// <summary>
        /// When user click on the number 2
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "2");
        }

        /// <summary>
        /// When user click on the number 3
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "3");
        }

        /// <summary>
        /// When user click on the number 4
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void FourBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "4");
        }

        /// <summary>
        /// When user click on the number 5
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "5");
        }

        /// <summary>
        /// When user click on the number 6
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SixBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "6");
        }

        /// <summary>
        /// When user click on the number 7
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "7");
        }

        /// <summary>
        /// When user click on the number 8
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EightBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "8");
        }

        /// <summary>
        /// When user click on the number 9
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void NineBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "9");
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
            ComputeTextBox.Text = (-1 * Int64.Parse(ComputeTextBox.Text)).ToString();
        }

        /// <summary>
        /// When user click on the number ","
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void CommaBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text += ".";
        }

        /// <summary>
        /// When user click on the number "+"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength > 0)
            {
                ComputeTextBox.Text += " + ";
            }
        }

        /// <summary>
        /// When user click on the number "-"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength > 0)
            {
                ComputeTextBox.Text += " - ";
            }
        }

        /// <summary>
        /// When user click on the number "x"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void MultBtn_Click(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength > 0)
            {
                ComputeTextBox.Text += " x ";
            }
        }

        /// <summary>
        /// When user click on the number "/"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void DivBtn_Click(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength > 0)
            {
                ComputeTextBox.Text += " / ";
            }
        }

        /// <summary>
        /// When user click on the number "%"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength > 0)
            {
                ComputeTextBox.Text += " % ";
            }
        }

        #endregion Symbols regions

        #region Actions buttons

        /// <summary>
        /// When user click on the number "CE"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = "0";
        }

        /// <summary>
        /// When user click on the number "<"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EraseBtn_Click(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength > 0 && position > 0 && position <= ComputeTextBox.TextLength)
            { 
                ComputeTextBox.Text = ComputeTextBox.Text.Remove(position - 1, 1);
                position--;
            } 
            else if (ComputeTextBox.TextLength > 0)
            {
                ComputeTextBox.Text = ComputeTextBox.Text.Remove(ComputeTextBox.TextLength - 1);
            }

        }

        /// <summary>
        /// When user click on the number "="
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EqualBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string toCalculate = Analyse.AnalyseAndReplace(ComputeTextBox.Text);
                DataTable dt = new DataTable();
                object result = dt.Compute(toCalculate, "");
                ComputeTextBox.Text = result.ToString();
            } 
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        #endregion Actions buttons

        #region TextBox events

        /// <summary>
        /// When a 0 is in text box and user input an other number
        /// Consist in replacement of 0 with the clicked number
        /// </summary>
        /// <param name="sender">System.Windows.Forms.TextBox</param>
        /// <param name="e">System.EventArgs</param>
        private void ComputeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ComputeTextBox.TextLength == 2 && ComputeTextBox.Text[0] == '0')
            {
                ComputeTextBox.Text = ComputeTextBox.Text.Remove(0, 1);
            }
        }

        /// <summary>
        /// When user click on the ComputedTextBox
        /// </summary>
        /// <param name="sender">System.Windows.Forms.TextBox</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ComputeTextBox_Click(object sender, System.EventArgs e)
        {
            position = ComputeTextBox.SelectionStart;
        }

        #endregion TextBox events
    }
}
