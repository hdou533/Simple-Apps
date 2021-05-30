using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fahrenheight_Click(object sender, EventArgs e)
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_f.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            

            float c = 5f / 9f * (f - 32);
            float k = c - 273;


            txt_c.Text = c.ToString();
            txt_k.Text = k.ToString();




        }

        private void btn_Celsius_Click(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_c.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }



            float f = c * (9 / 5) + 32;
            float k = c - 273;


            txt_f.Text = f.ToString();
            txt_k.Text = k.ToString();
        }

        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_k.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }



            
            float c = k + 273;
            float f = c * (9 / 5) + 32;


            txt_c.Text = c.ToString();
            txt_f.Text = f.ToString();
        }
    }
}
