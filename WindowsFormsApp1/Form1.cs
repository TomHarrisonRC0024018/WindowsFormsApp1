using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + textBox1.Text + " Question: 17 - 2 x 8 = 1, yes or no?");
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Correct rkid");
        }

        private void No_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Incorrect");
        }
    }
}
