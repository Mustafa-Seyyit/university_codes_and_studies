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

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sutunlar = { "ID", "Name", "Surname", "Age" };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in sutunlar)
                listUsers.Columns.Add(s);
            listUsers.View = View.Details;


        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Files|*.txt",ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    string line;
                    while ((line = sr.ReadLine()) != null){
                        string[] details = line.Split(',');
                        if (details.Length != 4)
                            continue;
                        
                        ListViewItem item = new ListViewItem(details);
                        listUsers.Items.Add(item);
                    }
                    sr.Close();
                }
            }
        }
    }
}
