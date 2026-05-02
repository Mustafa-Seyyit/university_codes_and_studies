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
using static Week10_EmployeeProject.DatabaseUtils;
namespace Week10_EmployeeProject
{
    public partial class FormJobTitle : Form
    {
        public FormJobTitle()
        {
            InitializeComponent();
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobTitle.Text))
                return;
            using (SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"insert into {jobTitleTableName}(title) values(@title)";
                cmd.Parameters.AddWithValue("@title",txtJobTitle.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Title Eklendi");
                con.Close();
                txtJobTitle.Clear();
                txtJobTitle.Focus();
            }
        }
    }
}
