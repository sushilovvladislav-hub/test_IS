using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleTypeCheck
{
    public partial class TriangleTypeCheck : Form
    {

        public TriangleTypeCheck()
        {
            InitializeComponent();
            SetupValidation();
            
        }

        private void SetupValidation()
        {
            tBoxSizeA.KeyPress += TextBox_KeyPress;
            tBoxSizeB.KeyPress += TextBox_KeyPress;
            tBoxSizeC.KeyPress += TextBox_KeyPress;

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            TextBox textBox = sender as TextBox;

            bool isDigit = char.IsDigit(e.KeyChar);
            bool isControl = char .IsControl(e.KeyChar);
            bool isDot = e.KeyChar == '.';

            if (!isDigit && !isControl && !isDot)
            {
                e.Handled = true;
                return;
            }

            if (isDot)
            {
                if (textBox.SelectionStart == 0 || textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    return; 
                }
            }

            if (e.KeyChar == '0')
            {
                if (textBox.SelectionStart == 0 && textBox.Text.StartsWith("0"))
                {
                    e.Handled = true;
                    return;
                }

            }
            
            if (isDigit && textBox.Text == "0" && textBox.SelectionStart == 1)
            {
                textBox.Text = e.KeyChar.ToString();
                textBox.SelectionStart = 1;
                e.Handled = true;
                return;
            }
            
        }
           

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
