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
    public partial class Form2 : Form
    {
       private Form myParent;
        public Form2(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }
        Decimal priceEachTicket = 0.0m;
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            priceEachTicket = 20.0m;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            priceEachTicket = 15.0m;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            priceEachTicket = 10.0m;
        }

         private void button2_Click(object sender, EventArgs e)
        {
            int intNumTickets = 0;
            Decimal decTicketCost = 0.0m;
            Decimal decSalesTax = 0.0m;
            Decimal decTotal = 0.0m;

            intNumTickets = int.Parse(textBox1.Text);
            decTicketCost = intNumTickets * priceEachTicket;
            decSalesTax = CalcTax(decTicketCost);
            decTotal = decTicketCost + decSalesTax;
            label1.Text = decTicketCost.ToString("$.00");
            label2.Text = decSalesTax.ToString("$.00");
            label3.Text = decTotal.ToString("$.00");
        }
    }
}
