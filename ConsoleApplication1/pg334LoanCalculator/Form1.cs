using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pg334LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int intMIN_MONTHS = 6;
        const int intMAX_MONTHS = 48;
        const float sngMONTHS_YEAR = 12.0f;
        const double dblNEW_RATE = 0.089;
        const double dblUSED_RATE = 0.095;
        double dblAnnualRate = dblNEW_RATE;

        private void button1_Click(object sender, EventArgs e)
        {
            int intCount = 0;
            int intMonths = 0;
            double dblLoan = 0.0;
            double dblPayment = 0.0;
            double dblIntrest = 0.0;
            double dblPrincipal = 0.0;

            try
            {
                intMonths = int.Parse(textBox3.Text);
                dblLoan = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter numeric values");
                return;
            }
            dblPayment = Financial.Pmt(dblAnnualRate / sngMONTHS_YEAR, intMonths, -dblLoan);
            listBox1.Items.Clear();

            for (intCount = 1; intCount <= intMonths; intCount++)
            {
                string strOut = string.Empty;
                dblIntrest = Financial.IPmt(dblAnnualRate / sngMONTHS_YEAR, intCount, intMonths, -dblLoan);
                dblPrincipal = Financial.PPmt(dblAnnualRate / sngMONTHS_YEAR, intCount, intMonths, -dblLoan);
                strOut += "Month: " + intCount;
                strOut += "  Payment: " + dblPayment.ToString("$.00");
                strOut += "  Intrest: " + dblIntrest.ToString("$.00");
                strOut += "  Principal: " + dblPrincipal.ToString("$.00");
                listBox1.Items.Add(strOut);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.CausesValidation = false;
            textBox2.CausesValidation = false;
            textBox3.CausesValidation = false;
            radioButton1.Checked = true;
            dblAnnualRate = dblNEW_RATE;
            label5.Text = dblNEW_RATE.ToString(".00%");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.CausesValidation = false;
            textBox2.CausesValidation = false;
            textBox3.CausesValidation = false;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dblAnnualRate = dblNEW_RATE;
                label5.Text = dblNEW_RATE.ToString(".00%");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dblAnnualRate = dblUSED_RATE;
                label5.Text = dblUSED_RATE.ToString(".00%");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(textBox1.Text, out _x))
            {
                MessageBox.Show("Cost must be a number.", "Invalid Vehicle Cost");
                textBox1.SelectAll();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(textBox2.Text, out _x))
            {
                MessageBox.Show("Down payment must be a number.", "Invalid Down Payment");
                textBox2.SelectAll();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            double _x = 0;
            if (!double.TryParse(textBox3.Text, out _x))
            {
                MessageBox.Show("Months must be a number.", "Error");
                textBox3.SelectAll();
                e.Cancel = true;
            }
            else
            {
                int intMonths = int.Parse(textBox3.Text);
                if (intMonths < intMIN_MONTHS || intMonths > intMAX_MONTHS)
                {
                    MessageBox.Show("Months must be in the range " + intMIN_MONTHS + " - " + intMAX_MONTHS, "Error");
                    textBox3.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}
