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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblId.Text = "Abcd";
            lblName.Text = "Myo Lwin Oo";
            lblAddress.Text = "No.123, Abcd road, Yangon";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblId.Text = "";
            lblName.Text = "";
            lblAddress.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
