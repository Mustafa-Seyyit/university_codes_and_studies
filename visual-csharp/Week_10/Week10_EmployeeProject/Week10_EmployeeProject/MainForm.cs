using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Week10_EmployeeProject.DatabaseUtils;


namespace Week10_EmployeeProject
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
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);

                using (SQLiteConnection con = getConnection())
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"create table if not exists {employeeTableName}(id integer primary key, firstName text, lastName text, address text, email text, mobileNo text, salary decimal, jobTitle integer, profilePhoto blob);";
                    cmd.CommandText += $"create table if not exists {jobTitleTableName}(id integer primary key, title text);";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Veritabanı Oluşturuldu");
                    con.Close();
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddJobTitle_Click(object sender, EventArgs e)
        {
            FormJobTitle frmJobTitle = new FormJobTitle();
            frmJobTitle.ShowDialog();
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            FormAddEmployee frmAddEmployee = new FormAddEmployee();
            frmAddEmployee.ShowDialog();
        }
    }
}
