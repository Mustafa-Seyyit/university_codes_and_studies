using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(trackbarWidth.Value, trackBarHeigth.Value);
        }

        private void trac_Scroll(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(trackbarWidth.Value, trackBarHeigth.Value);
        }

    }
}
