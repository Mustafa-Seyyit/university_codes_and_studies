using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public class User
    {
        public int id;
        public string first_name;
        public string last_name;

        public User(int id, string first_name,string last_name)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
        }



        public User(SQLiteDataReader dataReader)
        {
            try
            {
                id = dataReader.GetInt32(0);
                first_name = dataReader.GetString(1);
                last_name = dataReader.GetString(2);

            }
            catch(Exception exc)
            {
                System.Windows.Forms.MessageBox.Show("Invalid DataReader");
            }
        }

        public ListViewItem convertToListViewItem()
        {
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(first_name);
            item.SubItems.Add(last_name);
            return item;
        }

    }
}
