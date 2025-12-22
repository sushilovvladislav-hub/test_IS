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
            bool isControl = char.IsControl(e.KeyChar);
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

        private void btnDefine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxSizeA.Text) ||
                string.IsNullOrWhiteSpace(tBoxSizeB.Text) ||
                string.IsNullOrWhiteSpace(tBoxSizeC.Text))
            {

                MessageBox.Show("Пожалуйста, введите все три стороны треугольника",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            double SideA = double.Parse(tBoxSizeA.Text);
            double SideB = double.Parse(tBoxSizeB.Text);
            double SideC = double.Parse(tBoxSizeC.Text);

            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                MessageBox.Show("Такого треугольника не существует!\n" +
                                "Сумма любых двух сторон должна быть больше третьей.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                lblRes.Text = "Треугольник не существует";
                return;
            }

            string triangleType = DetermineTriangleType(SideA, SideB, SideC);

            lblRes.Text = triangleType;
        }

        private string DetermineTriangleType(double SideA, double SideB, double SideC)
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            double s1 = sides[0];
            double s2 = sides[1];
            double s3 = sides[2];

            const double epsilon = 1e-9;

            double s1_sq = s1 * s1;
            double s2_sq = s2 * s2;
            double s3_sq = s3 * s3;

            double sumSmallSquares = s1_sq + s2_sq;

            if (Math.Abs(s1 - s2) < epsilon && Math.Abs(s2 - s3) < epsilon)
            {
                return "Равносторонний треугольник";
            }
            if (Math.Abs(s1 - s2) < epsilon || Math.Abs(s1 - s3) < epsilon || Math.Abs(s2 - s3) < epsilon) 
            {
                return "Равнобедренный треугольник";
            }
            if (Math.Abs(s3_sq - sumSmallSquares) < epsilon)
            {
                return "Прямоугольный треугольник";
            }
            if (s3_sq > sumSmallSquares) 
            {
                return "Тупоугольный треугольник";
            }
            if (s3_sq < sumSmallSquares)
            {
                return "Остроугольный треугольник";
            }

            return "Ошибка определения типа";

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxSizeA.Clear();
            tBoxSizeB.Clear();
            tBoxSizeC.Clear();

            lblRes.Text = "Ожидание ввода значений...";

            pBoxRes = null;

        }
    }
}
