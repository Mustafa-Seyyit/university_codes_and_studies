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

namespace ProjeOdev
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void chartStudents_Click(object sender, EventArgs e)
        {
            int ogrenciSayisi = 0;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + "StudenDb.db"))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM Students";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    ogrenciSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            chartStudents.Series["OgrenciSayisi"].Points.Clear();
            chartStudents.Series["OgrenciSayisi"].Points.AddXY("Toplam Öğrenci", ogrenciSayisi);
        }
    }
}

