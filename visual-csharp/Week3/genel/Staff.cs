using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    internal class Staff
    {
        public string name;
        public string department;
        public int salary;

        public Staff(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
    }
}
