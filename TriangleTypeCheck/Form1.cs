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

            tBoxSizeA.Validating += TextBox_Validating;
            tBoxSizeB.Validating += TextBox_Validating;
            tBoxSizeC.Validating += TextBox_Validating;

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
                    e.Handled |= true;
                    return; 
                }
            }

            
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                return;
            }    
                

            if (!double.TryParse(textBox.Text.Replace(",", "."), out double value)) 
            {
                MessageBox.Show("Пожалуйста, введите корректное число!", "Ошибка ввода");
                
                textBox.SelectAll();
                e.Cancel = true;
                return;
            }

            if (value <= 0) 
            {
                MessageBox.Show("Число должно быть больше нуля!", "Ошибка ввода");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
