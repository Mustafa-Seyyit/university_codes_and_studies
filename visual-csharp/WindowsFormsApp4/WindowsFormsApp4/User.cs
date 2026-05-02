using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class User
    {
        public string id;
        public string firstName;
        public string lastName;
        public string age;
        public static char seperatorChar = ',';


        public User(string id, string firstName,string lastName,string age)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public User(string userLine)
        {
            if(!string.IsNullOrEmpty(userLine) && userLine.Split(seperatorChar).Length == 4)
            {

                string[] userData = userLine.Split(seperatorChar);
                id = userData[0];
                firstName = userData[1];
                lastName = userData[2];
                age = userData[3];
            }
        }

        public User(ListViewItem item)
        {
            if(item.SubItems.Count == 4) //4 sütun olmalı
            {
                id = item.SubItems[0].Text;//0. yani ID sütununda yazan değeri al
                firstName = item.SubItems[1].Text;
                lastName = item.SubItems[2].Text;
                age = item.SubItems[3].Text;
            }
        }


        public override string ToString()
        {
            return id+seperatorChar.ToString()+firstName+seperatorChar.ToString()+lastName+seperatorChar.ToString()+age;
        }

        public ListViewItem convertToListViewItem()
        {
            ListViewItem item = new ListViewItem(id);
            item.SubItems.Add(firstName);
            item.SubItems.Add(lastName);
            item.SubItems.Add(age);
            return item;
        }
    }
}
