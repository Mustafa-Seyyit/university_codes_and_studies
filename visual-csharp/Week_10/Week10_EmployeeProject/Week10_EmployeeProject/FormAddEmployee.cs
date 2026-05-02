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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
            getJobTitles();
        }

        private void btnSelectYourPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image |*.jpg;*.png;*.jpeg" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureProfilePhoto.Image = Image.FromFile(ofd.FileName);
                    btnSelectYourPhoto.Text = ofd.FileName;
                }
            }
        }

        
        public void getJobTitles()
        {
            using(SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = $"select * from {jobTitleTableName}";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataRow firstRow = ds.Tables[0].NewRow();
                firstRow[0] = selectedJobTitleId;
                firstRow[1] = "Select Job Title";
                ds.Tables[0].Rows.InsertAt(firstRow,0);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbJobTitles.DataSource = ds.Tables[0];
                    cmbJobTitles.DisplayMember = "title";
                    cmbJobTitles.ValueMember = "id";
                    cmbJobTitles.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                con.Close();
            }
        }
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            btnUpdateEmployee.Visible = false;
            cmbEmployeeList.Visible = false;
        }


        int selectedJobTitleId=0;
        private void cmbJobTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (DataRowView)cmbJobTitles.SelectedItem;
            if (selectedItem != null)
                //combobox'a verileri datasource olarak eklediğimiz yapıda veritabanından çektiğimiz tablonun id ve title sütunlarını kullandık
                //selectedItem ifadesini DataRowView olarak elde ettiğimizde seçilen verinin id sütunundaki verisini elde ettik.
                selectedJobTitleId = int.Parse(selectedItem["id"].ToString());

        }


        public byte[] imageToBlob(Image img)
        {
            
            using (MemoryStream ms = new MemoryStream()) {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }


        public void clearForm()
        {
            foreach (var c1 in Controls)
                if (c1 is TextBox txt1)
                    txt1.Clear();

            btnSelectYourPhoto.Text = "Select Your Photo";
            pictureProfilePhoto.Image = null;
            btnAddEmployee.Visible = true;
            btnUpdateEmployee.Visible = false;
            selectedJobTitleId = 0;
            cmbJobTitles.SelectedIndex = selectedJobTitleId;
            cmbEmployeeList.Visible = false;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            //eğer herhangi bir textbox boş geçildiyse oraya focus ol ve geriye kalan kodları çalıştırma(return)
            foreach(var cont in Controls)
                if(cont is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Focus();
                    return;
                }
            if (btnSelectYourPhoto.Text == "Select Your Photo" || pictureProfilePhoto.Image == null)
                return;

            decimal salary;
            if (!decimal.TryParse(txtSalary.Text, out salary)) //kullanıcı decimal bir değer girmediyse dönüşüm işlemi false döner ve return ederiz.
                return;


            using (SQLiteConnection con = getConnection())
            {
                con.Open();
                //SQLiteCommand cmd = new SQLiteCommand(con); //aşağıdakiyle aynı
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = $"insert into {employeeTableName}(firstName,lastName,address,email,mobileNo,salary,jobTitle,profilePhoto) values(@firstName,@lastName,@address,@email,@mobileNo,@salary,@jobTitle,@profilePhoto)";
                cmd.Parameters.AddWithValue("firstName",txtFirstName.Text);
                cmd.Parameters.AddWithValue("lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("mobileNo", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("jobTitle", selectedJobTitleId);
                cmd.Parameters.AddWithValue("profilePhoto", imageToBlob(pictureProfilePhoto.Image)); //pictureBox'ta yer alan görüntüyü blob veri türünde saklanacak hale getirip öyle gönderiyoruz.

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee eklendi");
                clearForm();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            btnAddEmployee.Visible = false;
            btnUpdateEmployee.Visible = true;
            cmbEmployeeList.Visible = true;


            using (SQLiteConnection con = getConnection())
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = $"select * from {employeeTableName}";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbEmployeeList.DataSource = ds.Tables[0];
                    cmbEmployeeList.DisplayMember = "firstName";
                    cmbEmployeeList.ValueMember = "id";
                    cmbEmployeeList.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

                con.Close();
            }
        }


        public Image blobToImage(byte[] blobData)
        {
            using(MemoryStream ms = new MemoryStream(blobData))
                return Image.FromStream(ms);
        }

        int selectedEmployeeId = -1;
        byte[] profilePhotoBytes;

        private void cmbEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (DataRowView)cmbEmployeeList.SelectedItem;
            if (selectedItem != null) {
                txtFirstName.Text = selectedItem["firstName"].ToString();
                txtLastName.Text = selectedItem["lastName"].ToString();
                txtEmail.Text = selectedItem["email"].ToString();
                txtAddress.Text = selectedItem["address"].ToString();
                txtMobileNo.Text = selectedItem["mobileNo"].ToString();
                txtSalary.Text = selectedItem["salary"].ToString();

                selectedJobTitleId = int.Parse(selectedItem["jobTitle"].ToString());
                cmbJobTitles.SelectedValue = selectedJobTitleId;


                selectedEmployeeId = int.Parse(selectedItem["id"].ToString());

                //Profil Fotoğrafını veritabanından çekip gösteiryoruz
                profilePhotoBytes = (byte[])selectedItem["profilePhoto"];
                pictureProfilePhoto.Image = blobToImage(profilePhotoBytes);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            foreach(var control in Controls )
                if(control is TextBox txt && string.IsNullOrEmpty(txt.Text))
                {
                    txt.Focus();
                    return;
                }
            if (cmbJobTitles.SelectedIndex == 0 || selectedJobTitleId <= 0)//ilk eleman select job title olduğu için onu saymıyoruz. kullanıcı onu seçemez
                return;

            if (pictureProfilePhoto.Image == null)
                return;
            decimal salary;
            if (!decimal.TryParse(txtSalary.Text, out salary))
                return;

            using (SQLiteConnection con = getConnection())
            {
                con.Open();

                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = $"UPDATE {employeeTableName} SET firstName=@firstName, lastName=@lastName, email=@email, address=@address, mobileNo=@mobileNo, salary=@salary, profilePhoto=@profilePhoto, jobTitle=@jobTitle WHERE id=@id";
                cmd.Parameters.AddWithValue("@id",selectedEmployeeId);
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobileNo", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@salary",salary );
                cmd.Parameters.AddWithValue("@jobTitle", selectedJobTitleId);


                if(btnSelectYourPhoto.Text == "Select Your Photo")
                    cmd.Parameters.AddWithValue("@profilePhoto", profilePhotoBytes);
                else
                    cmd.Parameters.AddWithValue("@profilePhoto", imageToBlob(pictureProfilePhoto.Image));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Güncellendi!");
                clearForm();
            }

        }
    }
}
