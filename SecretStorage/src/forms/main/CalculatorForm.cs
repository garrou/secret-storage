using SecretStorage.src.forms;
using SecretStorage.src.models;
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

        /// <summary>
        /// Cursor position
        /// </summary>
        private int position;

        /// <summary>
        /// MySQL connection
        /// </summary>
        private readonly Connection connection;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Application
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
            connection = new Connection();
            position = -1;
            Refresh();
        }

        #endregion Constructor

        #region Numbers events

        /// <summary>
        /// When user clicks on the button 0
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "0");
        }

        /// <summary>
        /// When user clicks on the button 1
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void OneBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "1");
        }

        /// <summary>
        /// When user clicks on the button 2
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "2");
        }

        /// <summary>
        /// When user clicks on the button 3
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "3");
        }

        /// <summary>
        /// When user clicks on the button 4
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void FourBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "4");
        }

        /// <summary>
        /// When user clicks on the button 5
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "5");
        }

        /// <summary>
        /// When user clicks on the button 6
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SixBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "6");
        }

        /// <summary>
        /// When user clicks on the button 7
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "7");
        }

        /// <summary>
        /// When user clicks on the button 8
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EightBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = TextBoxUtils.Put(ComputeTextBox.Text, ref position, "8");
        }

        /// <summary>
        /// When user clicks on the button 9
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
        /// When user clicks on the button "+/-"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void NegativeBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = (-1 * long.Parse(ComputeTextBox.Text)).ToString();
        }

        /// <summary>
        /// When user clicks on the button ","
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void CommaBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text += ".";
        }

        /// <summary>
        /// When user clicks on the button "+"
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
        /// When user clicks on the button "-"
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
        /// When user clicks on the button "x"
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
        /// When user clicks on the button "/"
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
        /// When user clicks on the button "%"
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

        /// <summary>
        /// When user clicks on the button "("
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void LeftParenthese_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text += "(";
        }

        /// <summary>
        /// When user clicks on the button ")"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void RightParenthese_Click(object sender, EventArgs e)
        {
            int nbLeftParentheses = 0;
            int nbRightParentheses = 0;

            foreach (char c in ComputeTextBox.Text)
            {
                if (c == '(')
                {
                    nbLeftParentheses++;
                } 
                else if (c == ')')
                {
                    nbRightParentheses++;
                }
            }

            if (nbLeftParentheses > 0 && nbLeftParentheses > nbRightParentheses)
            {
                ComputeTextBox.Text += ")";
            }
        }

        /// <summary>
        /// When user clicks on the button "x²"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void SquareBtn_Click(object sender, EventArgs e)
        { 
            ComputeTextBox.Text += "3,1415926535897932384626433832795";      
        }

        /// <summary>
        /// When user clicks on the button "1/x"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void OneOnBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text += "1/";
        }

        /// <summary>
        /// When user clicks on the button "CE"
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ComputeTextBox.Text = "0";
        }

        /// <summary>
        /// When user clicks on the button "<"
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

        #endregion Symbols regions

        #region Action button

        /// <summary>
        /// When user clicks on the button "="
        /// </summary>
        /// <param name="sender">System.Windows.Forms.Button</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void EqualBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string toCalculate = AnalyseUtils.AnalyseAndReplace(ComputeTextBox.Text);
                ComputeTextBox.Text = ComputeUtils.DoTheMath(toCalculate);

                bool isGoodPassword = connection.CheckIfLoginPagePassword(toCalculate);

                if (isGoodPassword)
                {
                    Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            } 
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Action button

        #region TextBox events

        /// <summary>
        /// When a 0 is in text box and user input an other button
        /// Consist in replacement of 0 with the clicked button
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
        /// When user clicks on the ComputedTextBox
        /// </summary>
        /// <param name="sender">System.Windows.Forms.TextBox</param>
        /// <param name="e">System.Windows.Forms.MouseEventArgs</param>
        private void ComputeTextBox_Click(object sender, System.EventArgs e)
        {
            position = ComputeTextBox.SelectionStart;
        }

        #endregion TextBox events

        #region Form event

        /// <summary>
        /// When user cliks on red cross
        /// </summary>
        /// <param name="sender">SecretStorage.src.forms.CalculatorForm</param>
        /// <param name="e">System.EventArgs</param>
        private void CalculatorForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Form event
    }
}
