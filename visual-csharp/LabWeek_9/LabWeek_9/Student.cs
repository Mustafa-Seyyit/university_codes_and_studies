using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek_9
{
    public class Student
    {
        public int index = -1;
        public string name;
        public int grade;


        public override string ToString()
        {
            return name + ":" + grade.ToString();
        }
    }
}
