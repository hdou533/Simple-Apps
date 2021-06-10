using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int startNum = 0;
            int stopNum = 10;

            startNum = int.Parse(txt_start.Text);
            stopNum = int.Parse(txt_stop.Text);

            int x = 0;

            for(x=startNum; x<=stopNum; x++)
            {
                int square_value = x * x;
                listBox1.Items.Add("The squared value of " + x + " is " + square_value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_start.Text = " ";
            txt_stop.Text = " ";
            listBox1.Items.Clear();
        }
    }
}
