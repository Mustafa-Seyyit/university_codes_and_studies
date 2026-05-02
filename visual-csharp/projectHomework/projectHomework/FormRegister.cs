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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjeOdev
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pass = txtPassword.Text;
            string passAgain = txtPasswordagain.Text;

            if (name == "" || pass == "" || passAgain == "")
            {
                MessageBox.Show("Tüm alanları doldurun!");
                return;
            }

            if (pass != passAgain)
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + "StudenDb.db"))
            {
                conn.Open();

                // Aynı kullanıcı var mı kontrol etme
                string kontrol = "SELECT COUNT(*) FROM Users WHERE Username=@u";

                using (SQLiteCommand cmd = new SQLiteCommand(kontrol, conn))
                {
                    cmd.Parameters.AddWithValue("@u", name);
                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kayıtlı!");
                        return;
                    }
                }

                string kulEkle = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";
                using (SQLiteCommand cmd = new SQLiteCommand(kulEkle, conn))
                {
                    cmd.Parameters.AddWithValue("@u", name);
                    cmd.Parameters.AddWithValue("@p", pass);
                    cmd.ExecuteNonQuery();
                }
                // Dosyaya log yazma işlemi
                File.AppendAllText("log.txt", DateTime.Now + " - Yeni kullanıcı kaydı: " + name + Environment.NewLine);

                MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");

                Formlogin fl = new Formlogin();
                fl.Show();
                this.Hide();

            }

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Formlogin lf = new Formlogin();
            this.Hide();
            lf.Show();
        }
    }
}
