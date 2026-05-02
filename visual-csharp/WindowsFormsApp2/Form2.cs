using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        private DBManagement dbManager;
        public Form2()
        {
            InitializeComponent();
            string dbFileName = "vp.db";
            dbManager = new DBManagement(dbFileName);

        }

        private void LoadNumbersToListBox()
        {
            lstNumbers.Items.Clear();
            //tüm sayıları GetNumbers metodu aracılığıyla çekelim
            List<int> numbers = dbManager.GetNumbers();
            //Sayıları foreach döngüsüyle teker teker elde edip Listbox'a ekleyelim.
            foreach (int number in numbers)
            {
                lstNumbers.Items.Add(number);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadNumbersToListBox();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int myNumber;
            if (!int.TryParse(txtNumber.Text, out myNumber))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
                return;
            }

            dbManager.AddNumber(myNumber);
            txtNumber.Clear();
            txtNumber.Focus();
            MessageBox.Show("Sayı eklendi!");
            lstNumbers.Items.Add(myNumber.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedItem == null)
            {
                MessageBox.Show("Lütfen listeden bir sayı seçin.");
                return;
            }

            int selectedNumber;
            if (!int.TryParse(lstNumbers.SelectedItem.ToString(), out selectedNumber))
            {
                MessageBox.Show("Geçersiz seçim.");
                return;
            }

            dbManager.DeleteNumber(selectedNumber);
            MessageBox.Show(selectedNumber + " veritabanından silindi.");
            lstNumbers.Items.Remove(lstNumbers.SelectedItem);
        }
    }
}
