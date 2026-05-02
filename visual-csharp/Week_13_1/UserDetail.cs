using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week_13_1.models;
namespace Week_13_1
{
    public partial class UserDetail : Form
    {
        public delegate void LogoutDelegate();
        public event LogoutDelegate LogoutEvent;
        public users activeUser;
        libraryEntities db = new libraryEntities();
        public UserDetail()
        {
            InitializeComponent();
        }


        public void setProfile()
        {
            lblId.Text = activeUser.id.ToString();
            lblName.Text = activeUser.first_name + " " + activeUser.last_name;
            lblEmail.Text = activeUser.email;
            lblPassword.Text = activeUser.password;
            lblAddress.Text = activeUser.address;
            lblAge.Text = (DateTime.Now.Year - activeUser.birth_date.Year).ToString();
        }

        public void loadData()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.books
                                              .Where(book=>book.user_id == activeUser.id)
                                              .ToList();
            dataGridView1.DataSource = db.books.Where(book => book.user_id == activeUser.id)
                .Select(record => new {
                    Id = record.id,
                    Author = record.author,
                    BookName = record.book_name,
                    ReadingDate = record.reading_date,
                    PageCount = record.page_count
                })
                .ToList();


            DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
            bc.HeaderText = "Manage";
            bc.Text = "Delete";
            bc.Name = "bcDelete";
            bc.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(bc);
        }
        private void UserDetail_Load(object sender, EventArgs e)
        {
            if (activeUser == null)
            {
                this.Close();
                return;
            }
            setProfile();
            loadData();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogoutEvent();
        }

        public void addNewRecord(string book_name, string author, int page_count, DateTime reading_date)
        {
            books book1 = new books();
            book1.author = author;
            book1.book_name = book_name;
            book1.page_count = page_count;
            book1.user_id = activeUser.id;
            book1.reading_date = reading_date;

            db.books.Add(book1);
            db.SaveChanges();

            MessageBox.Show("Added!!");
            loadData(); // Get All Records From Database

        }

        private void newRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecordForm frmNewRecord = new NewRecordForm();
            frmNewRecord.AddNewRecordEvent += addNewRecord;
            frmNewRecord.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    int recordId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    books deletedBook = db.books.Where(book => book.id == recordId).FirstOrDefault();
                    if (deletedBook == null)
                        return;
                    db.books.Remove(deletedBook);
                    db.SaveChanges();
                    MessageBox.Show("Removed!!!");
                    loadData();

                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
