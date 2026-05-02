using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_3
{
    public delegate void UpdateUserDelegate(User user);
    public partial class UpdateProfileForm : Form
    {
        public event UpdateUserDelegate UpdateUserEvent;
        public User user;
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {

            txtEmail.Text = user.email;
            txtPassword.Text = user.password;
            txtName.Text = user.name;
            txtAge.Text = user.age.ToString();
            txtAddress.Text = user.address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            user.name = txtName.Text;
            user.age = int.Parse(txtAge.Text);
            user.address = txtAddress.Text;
            UpdateUserEvent(user);

            this.Close();
        }
    }
}
