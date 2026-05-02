using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addList_Click(object sender, EventArgs e)
        {
            string kullanici = tx_bx_fullName.Text +","+tx_bx_EMail.Text+","+tx_bx_Age.Text;
            lst_bx1.Items.Add(kullanici);
            tx_bx_fullName.Clear();
            tx_bx_EMail.Clear();
            tx_bx_Age.Clear();
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\musta\OneDrive\Masaüstü\finalgörsel\hafta6\ListBox\O3\O3\users.txt", true);
            foreach (var item in lst_bx1.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            lst_bx1.Items.Clear();
        }
    }
}
