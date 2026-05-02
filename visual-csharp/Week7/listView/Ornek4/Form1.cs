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

namespace Ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID").Width = 150;
            listView1.Columns.Add("Firt Name").Width = 150;
            listView1.Columns.Add("Last Name").Width = 150;
            listView1.Columns.Add("Age").Width = 150;

            listView1.View = View.Details;
        }

        private void btn_loaduser_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "*.txt", Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    string line = "";

                    while ((line = sr.ReadLine()) != null && line.Split(',').Length == 4)
                    {

                        User user = new User(line);
                        ListViewItem item = user.toListViewItem(user);
                        listView1.Items.Add(item);
                    }
                    sr.Close();
                }
            }
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tx_bx_id.Text) && string.IsNullOrEmpty(tx_bx_firstname.Text) && string.IsNullOrEmpty(tx_be_lastname.Text) && string.IsNullOrEmpty(tx_be_lastname.Text))
                return;
            
            User user = new User(tx_bx_id.Text, tx_bx_firstname.Text, tx_be_lastname.Text, tx_bx_age.Text);
            listView1.Items.Add(user.toListViewItem(user));
            tx_bx_id.Clear();
            tx_bx_firstname.Clear();
            tx_be_lastname.Clear();
            tx_bx_age.Clear();
        }

        private void btn_removeuser_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void btn_saveUAF_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "*.txt", FileName = "users.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK && string.IsNullOrEmpty(sfd.FileName))
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    foreach (ListViewItem item in listView1.Items)
                    {
                        User user = new User(item);
                        sw.WriteLine(user.ToString());
                    }
                    sw.Dispose();
                    MessageBox.Show("dosya başarıyla kaydedildi");
                }
            }
        }
    }
}
