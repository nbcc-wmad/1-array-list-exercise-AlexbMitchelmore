//Alex Mitchelmore
//Array List Exercise
//2019-04-24

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {

        ArrayList message = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            message.Add("I");
            message.Add("Love");
            message.Add("Programming");
            message.Add("So");
            message.Add("Much");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            foreach (var items in message)
            {
                msg += $"{items.ToString()} ";
            }

            lblMessage.Text = msg;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            message.Reverse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            message.Insert(1, txtSecondPos.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.RemoveAt(1);
        }
    }
}
