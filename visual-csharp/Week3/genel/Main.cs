using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    internal class main
    {
        static void Main(string[] args)
        {
            Staff s1 = new Staff("fatmanur", "ai", 134);
            Staff s2 = new Staff("güven", "ai", 98);
            Staff s3 = new Staff("mustafa", "ai", 98723);
            Staff s4 = new Staff("seyyit", "ai", -987);
            Staff s5 = new Staff("doğan", "ai", 2345);

            ArrayList myList = new ArrayList();
            myList.Add(s1);
            myList.Add(s2);
            myList.Add(s3);
            myList.Add(s4);
            myList.Add(s5);

            Console.WriteLine(SumSalary(myList));
        }


        static int SumSalary(ArrayList al)
        {
            int sum = 0;
            foreach (Staff staff in al)
            {
                if (staff.salary < 0)
                    throw new SalaryException("negatif bir maaş olamaz");
                sum += staff.salary;
            }
            return sum;
        }


    }
}
