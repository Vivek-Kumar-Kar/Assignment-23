using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class LoginOperation
    {
        static List<Login> list = new List<Login>()
        {
            new Login {ID = 2567455,Password = "b1234"},
            new Login {ID = 2567456,Password = "b1235"},
            new Login {ID = 2567457,Password = "b1236"},
            new Login {ID = 2567458,Password = "b1237"},
            new Login {ID = 2567459,Password = "b1238"},
        };
        public static void login()
        {
            Login loginDetails = new Login();
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Login l = list.SingleOrDefault(e => e.ID == id && e.Password == password);
            if (l != null)
            {
                Console.WriteLine("Login Successfull!!");
            }
            else
            {
                Console.WriteLine("Invalid Details!!");
            }

        }
    }
}