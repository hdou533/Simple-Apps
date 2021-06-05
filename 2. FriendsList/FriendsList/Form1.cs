using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsList
{
    public partial class Form1 : Form
    {

        List<String> myFriends = new List<String>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AutoSize = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            myFriends.Add(txt_newFriends.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);

            label1.Text = myFriends.Count + " friends.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clearlist_Click(object sender, EventArgs e)
        {
            myFriends.Clear();
            txt_newFriends.Clear();
            label1.Text = "0 friend.";
            bs.ResetBindings(false);
        }
    }
}
