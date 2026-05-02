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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProjeOdev
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text.Trim();

            if (username == "" ||  password == "")
            {
                MessageBox.Show("kullanıcı adı ve şifre boş olamaz");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + "StudenDb.db"))
            {
                conn.Open();

                string komut = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";
                using (SQLiteCommand cmd = new SQLiteCommand(komut, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");

                        FormMain frm = new FormMain();
                        frm.Show();

                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                    }
                }

            }

        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frm = new FormRegister();
            frm.Show();
        }

        
    }
}
