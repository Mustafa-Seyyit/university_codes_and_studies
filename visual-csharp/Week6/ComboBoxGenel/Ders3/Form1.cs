using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            ntf_icon1.Visible = true;
            ntf_icon1.ShowBalloonTip(3000, "uyarııııı", " hackleniyon falan knk", ToolTipIcon.Info);
        }
    }
}
