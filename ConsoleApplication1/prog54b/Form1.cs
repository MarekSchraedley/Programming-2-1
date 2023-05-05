using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog54b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int var1 = int.Parse(textBox1.Text);
            int var2 = int.Parse(textBox2.Text);
            int var3 = int.Parse(textBox3.Text);
            int var4 = int.Parse(textBox4.Text); 
            double total = var1 + var2 + var3 + var4;
            double average = total / 4;
            label4.Text = total.ToString();
            label5.Text = average.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
