using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {

        decimal loan_amount = 0.00m;
        int months = 0;
        decimal interest = 0.005m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            /*
            try {
                loan_amount = decimal.Parse(txt_loanAmount.Text);
                months = int.Parse(txt_numberOfMonth.Text);
                interest = decimal.Parse(txt_interest.Text);

                int counter = 0;

                for (counter = 0; counter <= months; counter++)
                {
                    loan_amount = loan_amount * (1 + interest);
                    listBox1.Items.Add("At month " + counter + " you loan is " + loan_amount);

                }

            }
            catch
            {
                MessageBox.Show("Only numbers please.");
            }

            */


            if ((decimal.TryParse(txt_loanAmount.Text, out loan_amount)) 
                && (int.TryParse(txt_numberOfMonth.Text, out months)) 
                && (decimal.TryParse(txt_interest.Text, out interest)))
            {
                int counter = 0;
                while(counter <= months)
                {
                    loan_amount = loan_amount * (1 + interest);
                    listBox1.Items.Add("At month " + counter + " your loan is " + loan_amount.ToString("c"));
                    counter++;
                }
                txt_endingLoan.Text = loan_amount.ToString("c");
            }
            else
            {
                MessageBox.Show("Only numbers please.");
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_loanAmount.Text = " ";
            txt_numberOfMonth.Text = " ";
            txt_interest.Text = " ";
            txt_endingLoan.Text = " ";
            listBox1.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
