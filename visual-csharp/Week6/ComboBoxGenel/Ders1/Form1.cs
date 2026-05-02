using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_CSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_CSharp.Checked)
            {
                lbl_1.Text = rb_CSharp.Text;
            }
        }

        private void rb_PHP_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_PHP.Checked)
            {
                lbl_1.Text = rb_PHP.Text;
            }
        }

        private void rb_Java_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Java.Checked)
            {
                lbl_1.Text = rb_Java.Text;
            }
        }

        private void rb_Python_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Python.Checked)
            {
                lbl_1.Text = rb_Python.Text;
            }
        }
    }
}
