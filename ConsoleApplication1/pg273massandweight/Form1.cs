using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg273massandweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mass = Convert.ToDouble(textBox1.Text);
            double weight = mass * 9.8;
            if (weight > 1000)
                MessageBox.Show("Too Heavy");
            else if (weight < 10)
                MessageBox.Show("Too Light");
            else
                label3.Text = weight.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
