using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        string dbFileName = "vp.db";
        private void createDatabase()
        {

            if (!File.Exists(dbFileName)) //Eğer veritabanı dosyası yoksa
            {
                try
                {
                    // veritabanı dosyası yoksa sıfırdan oluşturmamız lazım.
                    SQLiteConnection.CreateFile(dbFileName);
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source = " + dbFileName))
                    {
                        connection.Open();
                        string queryText = "create table first_table(number1 INTEGER NOT NULL)";
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = queryText;
                        cmd.ExecuteNonQuery(); //Sorgunun çalıştırılmasını sağlayan kod
                        connection.Close();
                    }
                }
                catch(SQLiteException exc)
                {
                    MessageBox.Show("Hata Meydana Geldi  :"+exc.Message);
                }
                
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase();
            getNumbersFromDatabase();
        }
        private void getNumbersFromDatabase()
        {
            lstNumbers.Items.Clear();
            using(SQLiteConnection con = new SQLiteConnection($"Data Source = {dbFileName}"))
            {
                try
                {
                    con.Open();
                
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = "SELECT * FROM first_table";
                    cmd.Connection = con;
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("We don't have any numbers");
                        dataReader.Close();//önce datareader'ı kapatırız. Sonra sqliteConnection nesnesini
                        con.Close();
                        return;
                    }
                    while (dataReader.Read())
                    {
                        int number1 = dataReader.GetInt32(0);//0. sütunu int tipinden bir veri olarak getir.
                        lstNumbers.Items.Add(number1);
                    }
                    con.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int myNumber;
            //girilen sayıyı int'e çeviremiyorsam kullanıcı geçerli bir değer girmemiştir anlamına gelir.
            if (!int.TryParse(txtNumber.Text, out myNumber))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFileName))
            {
                try
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = $"INSERT INTO first_table(number1) values(@number1)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@number1",myNumber);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtNumber.Clear();
                    txtNumber.Focus();
                    MessageBox.Show("Inserted!!");
                    getNumbersFromDatabase();
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Error : "+exc.Message);
                }
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedItem == null) //Listbox'ta seçilen bir eleman yoksa bir şey yapmadan dön.
                return;

            int selectedNumber;//ListBox'ta seçilen sayıyı buraya atacağız.
            if (!int.TryParse(lstNumbers.SelectedItem.ToString(), out selectedNumber))
            {
                MessageBox.Show("Invalid Selected Item");
                return;
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection($"Data Source = {dbFileName}"))
                {
                    
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "delete from first_table where number1=@number1";
                    cmd.Parameters.AddWithValue("number1",selectedNumber);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                //eğer buraya kadar gelindiyse seçilen sayı veritabanından silinmiştir.
                MessageBox.Show(selectedNumber+" is removed from db");
                //Listbox'tan silindiğine emin olduğumuz bu sayıyı kaldıralım. Tüm verileri çekip göstermek efektif bir yöntem değildir. 
                //Çünkü her seferinde database'e bağlantı oluşturup tüm satırları çekmek gereksiz yük bindirir sistemlere. Bunun yerine zaten silindiğini bildiğimiz veriyi listbox'tan silelim. Böylece tüm güncel verileri çekmemize gerek kalmaz.
                lstNumbers.Items.Remove(lstNumbers.SelectedItem);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
