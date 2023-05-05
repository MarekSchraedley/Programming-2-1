using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program435Ticketsales
{
    public partial class Form3 : Form
    {
       private Form myParent;
        public Form3(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m;  // Sales Tax Rate
        private decimal CalcTax(decimal cost)
        {
            // Returns the sales tax on ticket sales
            return cost * decTAXRATE;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show(); // work on this part of the ticket form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intNumTickets = 0;
            decimal decTicketCost = 0.0m;
            decimal decSalesTax = 0.0m;
            decimal decTotal = 0.0m;

            intNumTickets = int.Parse(textBox1.Text);

        }
    }
}
