using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "My name is Marek Schraedley.\nMy favorite club is lego robotics.\nMy favorite quote is 'It does not matter how slowly you go as long as you do not stop' ~confucius";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
