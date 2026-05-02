using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_3
{
    public class User
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public string address;
        public int age;

        public User(int id, string email, string password, string name, string address, int age) { 
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
