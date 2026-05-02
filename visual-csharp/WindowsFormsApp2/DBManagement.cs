using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class DBManagement
    {
        private string dbFileName { get; set; }
        public string connectionString { get; }

        public DBManagement(string databaseFileName)
        {
            dbFileName = databaseFileName;
            connectionString = $"Data Source={dbFileName}";
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            if (!File.Exists(dbFileName))
            {
                try
                {
                    // Veritabanı dosyasını oluştur
                    SQLiteConnection.CreateFile(dbFileName);

                    // Tabloyu oluştur
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string queryText = "CREATE TABLE IF NOT EXISTS first_table(number1 INTEGER NOT NULL)";
                        using (SQLiteCommand cmd = new SQLiteCommand(queryText, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show("Veritabanı oluşturulurken hata meydana geldi: " + exc.Message);
                }
            }
        }

        public List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM first_table";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Kayıt bulunamadı.");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    int number = reader.GetInt32(0);
                                    numbers.Add(number);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Verileri çekerken hata meydana geldi: " + exc.Message);
            }
            return numbers;
        }

        public void AddNumber(int number)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO first_table(number1) VALUES(@number1)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@number1", number);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Veri eklerken hata meydana geldi: " + exc.Message);
            }
        }

        public void DeleteNumber(int number)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM first_table WHERE number1=@number1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@number1", number);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Veri silinirken hata meydana geldi: " + exc.Message);
            }
        }
    }
}
