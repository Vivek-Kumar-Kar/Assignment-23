using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class Login
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}