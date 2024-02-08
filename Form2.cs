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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 10;
            if (Convert.ToInt32(progressBar1.Value) > 99) 
            {
                timer1.Enabled = false;
                Close();
            }
        }
    }
}
