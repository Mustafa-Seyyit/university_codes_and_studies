using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genel
{
    public partial class lbl_1 : Form
    {
        public lbl_1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            string girilenDeger = txt_bx.Text;

            if (!girilenDeger.Contains('x'))
            {
                MessageBox.Show("yanlılş format Örnek: 600x500");
                return;
            }

            string[] parcalar = girilenDeger.Split('x');

            int width, height;

            bool widthOk = int.TryParse(parcalar[0], out width);
            bool heightOk = int.TryParse(parcalar[1], out height);

            if (widthOk && heightOk)
            {
                if (width < 100 && height < 100)
                {
                    MessageBox.Show("minimum değerler 100x100 dür.");
                    return;
                }

                this.Width = width;
                this.Height = height;
            }
            else
            {
                MessageBox.Show("hatalı format");
            }

        }
    }
}
