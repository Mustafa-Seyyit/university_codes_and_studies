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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_bx_ID.Text) || string.IsNullOrEmpty(tx_bx_name.Text))
                return;

            //listView'deki kaydı temsil eder
            ListViewItem item = new ListViewItem(tx_bx_ID.Text);
            item.SubItems.Add(tx_bx_name.Text);
            listView1.Items.Add(item);

            tx_bx_ID.Clear();   
            tx_bx_name.Clear();
            tx_bx_ID.Focus();
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
                return;
            foreach (ListViewItem item in listView1.SelectedItems)
                listView1.Items.Remove(item);
        }
    }
}
