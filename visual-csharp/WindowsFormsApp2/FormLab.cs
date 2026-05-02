using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace WindowsFormsApp2
{
    public partial class FormLab : Form
    {
        public FormLab()
        {
            InitializeComponent();
            startListView();
            createDatabase();
            fillListView();
        }


        Func<SQLiteConnection> getConnection = () => new SQLiteConnection("Data Source = user.db");
        public void startListView()
        {

            //sütunları listView'e ekle
            string[] columns = { "ID", "First Name", "Last Name" };
            Array.ForEach(columns, c => lstUsers.Columns.Add(c));

            //Sütunların gösterilmesini sağla
            lstUsers.View = View.Details;

            //Her sütunun genişliğini 100 yap.
            foreach (ColumnHeader c in lstUsers.Columns)
                c.Width = 100;
        }


        string dbFileName = "user.db";
        string tableName = "users";
        public void createDatabase()
        {
            if (!File.Exists(dbFileName))
            {
                try
                {
                    SQLiteConnection.CreateFile(dbFileName);
                    using (SQLiteConnection con = getConnection())
                    {

                        con.Open();
                        string sqlCreateTable = $"create table if not exists {tableName}(id integer primary key, first_name text, last_name text)";
                        SQLiteCommand cmd = new SQLiteCommand(sqlCreateTable, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        


        public void fillListView()
        {
            lstUsers.Items.Clear();
            using(SQLiteConnection con = getConnection())
            {

                con.Open();


                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = $"select * from {tableName}";
                cmd.Connection = con;
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("No record of any user.");
                    dataReader.Close();
                    con.Close();
                    return;
                }

                while (dataReader.Read())
                {
                    User user = new User(dataReader);
                    ListViewItem item = user.convertToListViewItem();
                    lstUsers.Items.Add(item);
                }

                dataReader.Close();
                con.Close();
            }
        }


        private void FormLab_Load(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
                return;


            using(SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into {tableName}(first_name,last_name) values(@firstName,@lastName)";
                cmd.Parameters.AddWithValue("@firstName",txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName",txtLastName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                fillListView();
                MessageBox.Show("User Successfully Saved.");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                return;
            using(SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from {tableName} where first_name='{txtFirstName.Text}'";
                
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    MessageBox.Show("There are no users with such a name");
                    dataReader.Close();
                    con.Close();
                    return;
                }

                dataReader.Read();//Önce İmleci o satırın üzerine getiriyoruz.
                User user = new User(dataReader);
                txtLastName.Text = user.last_name;

                dataReader.Close();
                con.Close();
            }
        }

        private void btnRemoveSelectedUser_Click(object sender, EventArgs e)
        {

            if (lstUsers.SelectedIndices.Count <= 0)
                return;

            int selectedId = int.Parse(lstUsers.SelectedItems[0].SubItems[0].Text);//
            using(SQLiteConnection con  = getConnection())
            {

                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"delete from {tableName} where id=@id";
                cmd.Parameters.AddWithValue("@id",selectedId);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User is removed");
                fillListView();

            }
        }
    }
}
