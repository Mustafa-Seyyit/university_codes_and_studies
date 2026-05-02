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
using System.Data.SQLite;
using System.IO;
using System.Xml.Linq;
namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            createDatabase();
        }


        public void createDatabase()
        {
            if (!File.Exists(DatabaseUtils.dbFileName))
            {
                SQLiteConnection.CreateFile(DatabaseUtils.dbFileName);

                using(SQLiteConnection con = DatabaseUtils.getConnection())
                {
                    con.Open();



                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = @"create table if not exists "+DatabaseUtils.employeeTableName+@"(
                    id integer primary key, firstName text, lastName text, address text, email text, mobileNo text, salary integer, jobTitle integer, profilePhoto blob
                    );
                    create table if not exists "+DatabaseUtils.jobTableName+@"(id integer primary key, title text);
";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Database oluşturuldu!");
                    con.Close();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnAddJobTitle_Click(object sender, EventArgs e)
        {
            FormAddJobTitle frmJob = new FormAddJobTitle();
            frmJob.ShowDialog();

        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            FormAddEmployee frmEmployee = new FormAddEmployee();
            frmEmployee.ShowDialog();
        }
    }
}
