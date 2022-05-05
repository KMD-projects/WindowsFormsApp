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
            GetInput();
            result = firstNum / secondNum;
            PrintResult();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetInput()
        {
            try
            {
                firstNum = Convert.ToDouble(txtFirstNumber.Text);
                secondNum = Convert.ToDouble(txtSecondNumber.Text);
            } catch(Exception)
            {

            }
        }

        private void PrintResult()
        {
            lblResult.Text = "First Number: " + firstNum + "\n" + "Second Number: " + secondNum + "\n" + "Result: " + result;
        }
    }
}
