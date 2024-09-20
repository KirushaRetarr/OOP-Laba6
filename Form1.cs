using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba6_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string substring = textBox2.Text;

            string updateText = text.Replace(substring, "");

            textBox1.Text = updateText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
