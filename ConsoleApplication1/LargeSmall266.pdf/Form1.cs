using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargeSmall266.pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(textBox1.Text);
            int numB = int.Parse(textBox2.Text);
            if (numA > numB)
            {
                label1.Text = "Value A is greater than value B";
            }
            if (numA < numB)
            {
                label1.Text = "Value A is less than value B";
            }
            if (numA == numB)
            {
                label1.Text = "Value A is equal to value B";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
