using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week_13_1.models;
namespace Week_13_1
{
    public partial class Form1 : Form
    {

        libraryEntities db = new libraryEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            users user1 = new users();
            user1.first_name = txtFirstName.Text;
            user1.last_name = txtLastName.Text;
            user1.birth_date = dateTimePicker1.Value;
            user1.email = txtEmailRegister.Text;
            user1.password = txtPasswordRegister.Text;
            user1.address = txtAddress.Text;


            db.users.Add(user1);
            db.SaveChanges();

            MessageBox.Show("Registered!!");
            tabControl1.SelectedIndex = 0;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            users existingUser = db.users.Where(user => user.email == txtSignInEmail.Text && user.password == txtSignInPassword.Text).FirstOrDefault();
            if(existingUser == null)
            {
                MessageBox.Show("Your credentials are wrong!!");
                return;
            }
            this.Visible = false;
            UserDetail frmUserDetail = new UserDetail();
            frmUserDetail.activeUser = existingUser;
            frmUserDetail.LogoutEvent += logoutHandle;
            frmUserDetail.ShowDialog();
        }

        public void logoutHandle()
        {
            this.Visible = true;
        }
    }
}
