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

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            foreach (var eleman in cmb_bx1.Items)
            {
                lst_bx1.Items.Add(eleman);
            }
        }
    }
}
