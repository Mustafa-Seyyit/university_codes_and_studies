using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek4
{
    internal class User
    {
        public string ID;
        public string FName;
        public string LName;
        public string Age;

        public User(string ID, string FName, string LName, string age)
        {

            this.ID = ID;
            this.FName = FName;
            this.LName = LName;
            this.Age = age;
        }

        public User(string line) //dosyadan okunan bir satırı user nesnesine çeviren program
        {
            string[] data = line.Split(',');

            if (data.Length != 4)
                return;
            ID = data[0];
            FName = data[1];
            LName = data[2];
            Age = data[3];
        }

        public User(ListViewItem item)
        {
            ID = item.SubItems[0].Text;
            FName = item.SubItems[1].Text;
            LName = item.SubItems[2].Text;
            Age = item.SubItems[3].Text;
        }

        public ListViewItem toListViewItem(User user)
        {
            return new ListViewItem(new[] { ID, FName, LName, Age });
            
        }

        public override string ToString()
        {
            return $"{ID}+{FName}+{LName}+{Age}";
        }

    }
}
