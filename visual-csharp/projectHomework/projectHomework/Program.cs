using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace ProjeOdev
{
    internal static class Program
    {

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateTables();
            Application.Run(new Formlogin());
        }

        static void CreateTables()
        {
            if (!File.Exists("StudenDB.db")){

                try
                {
                    SQLiteConnection.CreateFile("StudentDB.db");
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + "StudenDb.db"))
                    {
                        connection.Open();
                        string usersTable = @"
                            CREATE TABLE IF NOT EXISTS Users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT,
                            Password TEXT
                            );";
                        SQLiteCommand cmd1 = new SQLiteCommand();
                        cmd1.CommandText = usersTable;
                        cmd1.Connection = connection;
                        cmd1.ExecuteNonQuery();

                        string students = @"
                            CREATE TABLE IF NOT EXISTS Students (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT,
                            Age INTEGER,
                            Department TEXT
                            );";
                        SQLiteCommand cmd2 = new SQLiteCommand();
                        cmd2.CommandText = students;
                        cmd2.Connection = connection;
                        cmd2.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

                            
    }
}
