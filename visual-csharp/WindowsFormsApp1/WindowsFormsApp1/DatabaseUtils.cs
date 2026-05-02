using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class DatabaseUtils
    {
        public static string dbFileName = "application.db";
        public static string jobTableName = "jobs";
        public static string employeeTableName = "employees";
        public static Func<SQLiteConnection> getConnection = () => new SQLiteConnection($"Data Source = {dbFileName}");

    }
}
