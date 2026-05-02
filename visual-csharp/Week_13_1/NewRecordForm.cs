using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_13_1
{
    public partial class NewRecordForm : Form
    {
        public delegate void AddNewRecordDelegate(string book_name, string author, int page_count, DateTime reading_date);
        public event AddNewRecordDelegate AddNewRecordEvent;

            public NewRecordForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewRecordEvent(txtBookName.Text, txtAuthor.Text,int.Parse(txtPageCount.Text),dateTimePicker1.Value);
        }

        private void NewRecordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
