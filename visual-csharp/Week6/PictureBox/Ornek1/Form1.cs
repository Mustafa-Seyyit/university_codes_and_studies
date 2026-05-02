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

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            pic_bx1.SizeMode =PictureBoxSizeMode.Normal;
        }

        private void rb_stretchımage_CheckedChanged(object sender, EventArgs e)
        {
            pic_bx1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rb_autosize_CheckedChanged(object sender, EventArgs e)
        {
            pic_bx1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void rb_zoom_CheckedChanged(object sender, EventArgs e)
        {
            pic_bx1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
