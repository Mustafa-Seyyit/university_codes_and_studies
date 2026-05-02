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

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] aylar =
            {
                "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık"
            };

            foreach (var item in aylar)
            {
                dud_1.Items.Add(item);
            }

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_2.Text = nup1.Value.ToString()+"/"+dud_1.SelectedItem.ToString()+"/"+nup2.Value.ToString();
            lbl_2.Visible = true;
        }
    }
}
