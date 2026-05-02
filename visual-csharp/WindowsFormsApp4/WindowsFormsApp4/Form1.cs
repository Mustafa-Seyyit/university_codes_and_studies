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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] listViewColumns = { "ID", "First Name", "Last Name", "Age" };
        private void Form1_Load(object sender, EventArgs e)
        {
            Array.ForEach(listViewColumns, c => listViewUsers.Columns.Add(c));


            //aşağıdaki  ve yukardaki foreach döngüsü aynı işi yapar.

            //foreach (string c in listViewColumns)
            //    listViewUsers.Columns.Add(c);

            listViewUsers.View = View.Details;//Sütunların görüntülenebilmesi için
        }


        public void fillUserFromFile()
        {

            listViewUsers.Items.Clear();// ListView'deki tüm satırları temizle.
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text File|*.txt",ValidateNames=true,Multiselect=false})
            {
                if(ofd.ShowDialog() == DialogResult.OK  && !string.IsNullOrEmpty(ofd.FileName))
                {

                    StreamReader sr = new StreamReader(ofd.FileName);//dosyayı okumaya başla
                    string line;
                    while((line = sr.ReadLine()) != null && line.Split(',').Length == 4)
                    {
                        Console.WriteLine(line);
                        User user = new User(line);
                        listViewUsers.Items.Add(user.convertToListViewItem()); //user nesnesindeki verilerle ListViewITem nesnesi oıluştur ve unu ListView'e aktar.
                    }

                    sr.Dispose();//dosyayı kapat.
                }
            }
        }
        private void btnLoadUserFromFile_Click(object sender, EventArgs e)
        {
            
            fillUserFromFile();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtAge.Text))
                return;

                foreach(ListViewItem item in listViewUsers.Items)
                if (item.SubItems[0].Text == txtID.Text)
                {
                    MessageBox.Show("Bu ID Zaten Daha Önce Eklendi");
                    return;
                }
            User user = new User(txtID.Text,txtFirstName.Text,txtLastName.Text,txtAge.Text);
            listViewUsers.Items.Add(user.convertToListViewItem());
        }

        private void btnRemoveUsers_Click(object sender, EventArgs e)
        {
            if(listViewUsers.SelectedIndices.Count > 0)
            {
                foreach (ListViewItem item in listViewUsers.SelectedItems)
                    listViewUsers.Items.Remove(item);
            }else
                MessageBox.Show("En az bir tane değer seçiniz.!!!");
        }

        private void btnSaveUsersAsFile_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { FileName="userList.txt", Filter = "Only Text|*.txt", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {

                    StreamWriter sw = new StreamWriter(sfd.FileName,false); //false=> Dosya varsa sil ve yeniden oluştur. İçindeki verilerin sonuna EKLEME
                    foreach(ListViewItem item in listViewUsers.Items)
                    {
                        User user = new User(item);
                        sw.WriteLine(user.ToString()); //user nesnnesini dosya yazdım . user.toString/()
                        sw.WriteLine("Text Bazlı İçerik");
                    }
                    sw.Dispose();
                }
            }
        }
    }
}
