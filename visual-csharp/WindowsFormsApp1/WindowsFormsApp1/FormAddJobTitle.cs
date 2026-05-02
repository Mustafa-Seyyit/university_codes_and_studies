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

namespace WindowsFormsApp1
{
    public partial class FormAddJobTitle : Form
    {
        public FormAddJobTitle()
        {
            InitializeComponent();
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobTitle.Text))
            {
                txtJobTitle.Focus();
                return;
            }


            using (SQLiteConnection con = DatabaseUtils.getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"insert into {DatabaseUtils.jobTableName}(title) values(@title)";
                cmd.Parameters.AddWithValue("@title",txtJobTitle.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Eklendi!");
                txtJobTitle.Text = "";
                txtJobTitle.Focus();

            }

        }
    }
}
