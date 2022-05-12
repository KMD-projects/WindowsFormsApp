using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Calculator : Form
    {
        private double firstNum, secondNum, result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            GetInput();
            result = firstNum + secondNum;
            PrintResult();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            GetInput();
            result = firstNum - secondNum;
            PrintResult();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetInput();
            result = firstNum * secondNum;
            PrintResult();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = GetInput();

                if (!success) return;

                if (secondNum == 0) throw new DivideByZeroException();
                
                result = firstNum / secondNum;
                PrintResult();
            } catch (DivideByZeroException ex)
            {
                MessageBox.Show("Cannot divide by zero.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool GetInput()
        {
            try
            {
                firstNum = Convert.ToDouble(txtFirstNumber.Text);
                secondNum = Convert.ToDouble(txtSecondNumber.Text);
                return true;
            } catch(FormatException)
            {
                MessageBox.Show("Invalid numbers.");
                return false;
            }
        }

        private void PrintResult()
        {
            lblResult.Text = "First Number: " + firstNum + "\n" + "Second Number: " + secondNum + "\n" + "Result: " + result;
        }
    }
}
