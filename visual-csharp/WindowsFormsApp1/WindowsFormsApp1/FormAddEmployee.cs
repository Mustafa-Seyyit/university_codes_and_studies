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

namespace WindowsFormsApp1
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
            GetJobTitleList();
        }



        public void GetJobTitleList()
        {
            using (SQLiteConnection con = DatabaseUtils.getConnection())
            {

                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"select * from {DatabaseUtils.jobTableName}";
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();

                da.Fill(ds);


                var firstRow = ds.Tables[0].NewRow();
                firstRow[0] = 0; //id değeri olarak
                firstRow[1] = "Select Job Title"; // title Değeri olarak

                ds.Tables[0].Rows.InsertAt(firstRow,0); //ilk sıraya ekliyoruz

                if (ds.Tables[0].Rows.Count > 0) {
                    cmbJobTitles.DataSource = ds.Tables[0]; //Tablodaki tüm satırları veri kaynağı olarak kullan
                    cmbJobTitles.DisplayMember = "title"; //Tablodaki satırlardan gelen verilerdeki title sütununu göster text olarak
                    cmbJobTitles.ValueMember = "id"; //Tablodaki satırlardan gelen verilerdeki id sütunundan çek
                    cmbJobTitles.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

                con.Close();
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtMobileNo.Text) || string.IsNullOrEmpty(txtSalary.Text))
                return;


            if (pictureProfilePhoto.Image == null)
            {
                MessageBox.Show("Profile Fotoğrafını Seçiniz");
                return;
            }

            int salary;

            if (!int.TryParse(txtSalary.Text, out salary))
                return;

            using (SQLiteConnection con = DatabaseUtils.getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"insert into {DatabaseUtils.employeeTableName}(firstName,lastName,address,email,mobileNo,salary,jobTitle,profilePhoto) values(@firstName,@lastName,@address,@email,@mobileNo,@salary,@jobTitle,@profilePhoto)";
                cmd.Parameters.AddWithValue("@firstName",txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email",txtEmail.Text);
                cmd.Parameters.AddWithValue("@address",txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobileNo",txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@salary",salary);
                cmd.Parameters.AddWithValue("@jobTitle",selectedTitleId);
                cmd.Parameters.AddWithValue("@profilePhoto", ImageToBlob(btnSelectYourPhoto.Text));
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved!!");
                clearEmployee();
            }


        }

        private void clearEmployee()
        {
            foreach (Control control in Controls)
                if (control is TextBox)
                    control.Text = "";

            selectedTitleId = 0;
            cmbJobTitles.Text = "";
            pictureProfilePhoto.Image = null;
            btnSelectYourPhoto.Text = "Select Profile Photo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog { Filter = "Image (*.png)|*.png | All Files|*.*"}) { 
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureProfilePhoto.Image = Image.FromFile(dlg.FileName);
                    btnSelectYourPhoto.Text = dlg.FileName;
                }
            }
        }



        int selectedTitleId;
        private void cmbJobTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (DataRowView)cmbJobTitles.SelectedItem;
            selectedTitleId = int.Parse(selectedItem["id"].ToString());
        }


        private byte[] ImageToBlob(string imagePath)
        {
            using( var ms = new MemoryStream())
            {
                Image img = Image.FromFile(imagePath);
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
