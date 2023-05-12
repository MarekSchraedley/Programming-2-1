using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lang122dfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int lcv = -12;
             listBox1.Items.Add("Number\t\tPolynomial Result");
             while (lcv <= 16)
             {
                 double poly = Math.Pow(lcv, 6) - 3 * Math.Pow(lcv, 5) - 93 * Math.Pow(lcv, 4) + 87 * Math.Pow(lcv, 3) + 1596 * Math.Pow(lcv, 2) - 1380 * lcv - 2800;
                 listBox1.Items.Add(lcv + "\t\t" + poly);
                 lcv++;
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
