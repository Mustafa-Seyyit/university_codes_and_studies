using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_3
{
    public delegate void AddNewRecordDelegate(string bookName, string author, int pageCount);
    public partial class NewRecordForm : Form
    {
        public event AddNewRecordDelegate AddNewRecordEvent;
        public NewRecordForm()
        {
            InitializeComponent();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            AddNewRecordEvent(txtBookName.Text,txtAuthor.Text, int.Parse(txtPageCount.Text));
            this.Close();

        }
    }
}
