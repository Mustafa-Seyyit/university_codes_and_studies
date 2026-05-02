using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_EmployeeProject
{
    public static class DatabaseUtils
    {
        public static string dbFileName = "application.db";
        public static string jobTitleTableName = "job_titles";
        public static string employeeTableName = "employees";
        public static Func<SQLiteConnection> getConnection = () => new SQLiteConnection($"Data Source = {dbFileName}");
    }
}
