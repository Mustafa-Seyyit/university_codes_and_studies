using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
           StreamReader sr = new StreamReader(@"C:\Users\musta\OneDrive\Masaüstü\finalgörsel\hafta6\LabSorusu\LabSorusu\admins.txt");
            string line = "";
            string email = tx_bx_Email.Text;
            string password = tx_bx_Password.Text;
            bool isAdmin = false;

           while ((line = sr.ReadLine()) != null){
                string[] temp = line.Split(',');
                if (temp[0].Equals(email) && temp[1].Equals(password))
                {
                    isAdmin = true;
                    break;
                }
                sr.Close();

            }

            if (isAdmin)
            {
                grp_bx_signin.Visible = false;
                grp_bx_userlist.Visible = true;
                MessageBox.Show("giriş başarılı");
            }
            else
            {
                MessageBox.Show("yanlış bilgiler tekrar deneyiniz");
                tx_bx_Email.Clear();
                tx_bx_Password.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\musta\OneDrive\Masaüstü\finalgörsel\hafta6\LabSorusu\LabSorusu\users.txt");

            string ad = "";
            string soyad = "";
            string line = "";

            while ((line = sr.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                ad = temp[1];
                soyad = temp[2];

                cmb_bx.Items.Add((ad + " " + soyad));
            }
            sr.Close ();
            
        }

        private void cmb_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_bx.Items.Clear();
            string[] temp = cmb_bx.SelectedItem.ToString().Split(' ');
            string ad = temp[0];
            string soyad = temp[1];
            string index = "";
            string yas = "";
            string user = "";

            StreamReader sr = new StreamReader(@"C:\Users\musta\OneDrive\Masaüstü\finalgörsel\hafta6\LabSorusu\LabSorusu\users.txt");

           while ((user = sr.ReadLine()) != null)
            {
                string[] userData = user.Split(',');
                if (userData[1].Equals(ad) && userData[2].Equals(soyad))
                {
                    index = userData[0];
                    yas = userData[3];
                    break;
                }
            }
            sr.Close();

            lst_bx.Items.Add((index + " " + ad + " " + soyad + " " + yas));

        }
    }
}
