using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_3
{
    public delegate void LogOutDelegate();
    public partial class Form2 : Form
    {
        public User user;
        public event LogOutDelegate LogoutEvent;
        public Form2()
        {
            InitializeComponent();
        }


        public void fillUserProfile()
        {
            lblId.Text = user.id.ToString();
            lblEmail.Text = user.email;
            lblPassword.Text = user.password;
            lblAddress.Text = user.address;
            lblName.Text = user.name;
            lblAge.Text = user.age.ToString();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            fillUserProfile();
            getAllRecordsFromDB();
        }


        public void getAllRecordsFromDB()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = users.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM user_books WHERE user_id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id", user.id);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("ID");
                    dataTable.Columns.Add("Book Name");
                    dataTable.Columns.Add("Author");
                    dataTable.Columns.Add("Page Count");

                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["ID"] = int.Parse(dataReader["id"].ToString());
                        row["Book Name"] = dataReader["book_name"].ToString();
                        row["Author"] = dataReader["author"].ToString();
                        row["Page Count"] = dataReader["page_count"].ToString();
                        dataTable.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataReader.Close();
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogoutEvent();
        }

        private void newBookRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecordForm newRecordForm = new NewRecordForm();
            newRecordForm.AddNewRecordEvent += addNewRecord;
            newRecordForm.ShowDialog();
        }


        public void addNewRecord(string bookName, string author, int pageCount)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = users.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO user_books(user_id,book_name, author, page_count) VALUES(@user_id,@book_name, @author, @page_count)";
                    cmd.Parameters.AddWithValue("@user_id", user.id);
                    cmd.Parameters.AddWithValue("@book_name", bookName);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@page_count", pageCount);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    getAllRecordsFromDB();
                    MessageBox.Show("A New Record is Inserted!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateUser(User updatedUser)
        {

            this.user = updatedUser;
            //Update the user on database
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(@"Data Source = users.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "UPDATE users SET email=@email, password=@password, name=@name, address=@address, age=@age WHERE id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id",user.id);
                    cmd.Parameters.AddWithValue("@email",user.email);
                    cmd.Parameters.AddWithValue("@password",user.password);
                    cmd.Parameters.AddWithValue("@name",user.name);
                    cmd.Parameters.AddWithValue("@address", user.address);
                    cmd.Parameters.AddWithValue("@age", user.age);
                    cmd.ExecuteNonQuery();
                    fillUserProfile();
                    con.Close();
                    MessageBox.Show("Updated!!!");
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }


        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm updateFrm = new UpdateProfileForm();
            updateFrm.user = user;
            updateFrm.UpdateUserEvent += updateUser;
            updateFrm.ShowDialog();
        }
    }
}
