using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ism = 0;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ism = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ism = 1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ism == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Left.ToString() + " : " + Top.ToString();
        }
    }
}
