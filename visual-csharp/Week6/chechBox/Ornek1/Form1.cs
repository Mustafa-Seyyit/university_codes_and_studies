using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_isChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                if (cb.Checked)
                    listBox1.Items.Add(cb.Text);
                else
                    listBox1.Items.Remove(cb.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
