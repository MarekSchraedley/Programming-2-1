using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg347Sum
{
    public partial class InputNeeded : Form
    {
        private Form myParent;
        public InputNeeded(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int total = 0;
            for (int lcv = 0; lcv <= num; lcv++)
            {
                total += lcv;
            }
            MessageBox.Show("The sum of the numbers 1 through " + num.ToString() + " is " + total.ToString(), "Sum of Numbers");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
