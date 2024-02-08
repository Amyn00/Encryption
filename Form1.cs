using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                textBox2.Text = cr.ConvertSHA1(textBox1.Text);
            }
            if (radioButton2.Checked) 
            {
                textBox2.Text = cr.ConvertMD5(textBox1.Text);
            }
            if (radioButton3.Checked) 
            {
                textBox2.Text = cr.ConvertSHA256(textBox1.Text);
            }
            if (radioButton4.Checked) 
            {
                textBox2.Text = cr.ConvertSHA512(textBox1.Text);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
