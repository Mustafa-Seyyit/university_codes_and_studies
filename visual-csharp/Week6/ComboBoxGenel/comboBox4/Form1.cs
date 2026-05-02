using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string eklenecek = txt_bx.Text;
            txt_bx.Text = "";
            cmb_bx.Items.Add(eklenecek);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecek = txt_bx.Text;
            txt_bx.Text = "";
            int index = cmb_bx.Items.IndexOf(silinecek);
            if (index == -1)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500, "hataaaaaa", "NotFound", ToolTipIcon.Info);
            }
            cmb_bx.Items.Remove(silinecek);
        }

        private void btn_onceki_Click(object sender, EventArgs e)
        {
            if (cmb_bx.SelectedIndex != 0)
            {
                cmb_bx.SelectedIndex -= 1;
            }
            else
            {
                MessageBox.Show("zaten ilk değerdesiniz");
            }
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            if (cmb_bx.SelectedIndex != cmb_bx.Items.Count - 1)
            {
                cmb_bx.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show("zaten son değerdesiniz.");
            }
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            if (cmb_bx.Items.Count > 0)
            {
                int index = cmb_bx.SelectedIndex;
                MessageBox.Show("index: " + index.ToString()+ " " + "eleman: " + cmb_bx.SelectedItem);
            }

        }

        private void cmb_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("değişti");
            
        }
    }
}
