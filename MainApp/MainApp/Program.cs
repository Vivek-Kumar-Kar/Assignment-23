using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Login Page");
                LoginOperation.login();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally { Console.ReadKey(); }


        }
    }
}