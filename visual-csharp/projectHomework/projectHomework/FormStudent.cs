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

namespace ProjeOdev
{

    public partial class FormStudent : Form
    {
        public delegate void StudentAddedEventHandler(string studentName);
        public event StudentAddedEventHandler StudentAdded;

        public FormStudent()
        {
            InitializeComponent();
            StudentAdded += FormStudent_StudentAdded;
        }

        private void FormStudent_StudentAdded(string studentName)
        {
            MessageBox.Show(studentName + " adlı öğrenci eklendi (Custom Event)");
        }


        private void FormStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }


        void LoadStudents()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + "StudenDb.db"))
            {
                conn.Open();

                string sql = "SELECT * FROM Students";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvStudents.DataSource = dt;
            }
        }

        void ClearInputs()
        {
            txtName.Clear();
            txtDepartment.Clear();
            nudAge.Value = 1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string department = txtDepartment.Text.Trim();
            int age = (int)nudAge.Value;

            if (name == "" || department == "")
            {
                MessageBox.Show("Tüm alanları doldurun!");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + "StudenDb.db"))
            {
                conn.Open();

                string sql = "INSERT INTO Students (Name, Age, Department) VALUES (@n, @a, @d)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@a", age);
                    cmd.Parameters.AddWithValue("@d", department);
                    cmd.ExecuteNonQuery();
                }
            }

            File.AppendAllText("log.txt",
       DateTime.Now + " - Öğrenci eklendi: " + name + Environment.NewLine);

            StudentAdded?.Invoke(name);

            LoadStudents();
            ClearInputs();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek öğrenci seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Id"].Value);
            string name = dgvStudents.SelectedRows[0].Cells["Name"].Value.ToString();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + "StudenDb.db"))
            {
                conn.Open();

                string sql = "DELETE FROM Students WHERE Id=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            File.AppendAllText("log.txt",
        DateTime.Now + " - Öğrenci silindi: " + name + Environment.NewLine);

            LoadStudents();

        }
        
    }
}
