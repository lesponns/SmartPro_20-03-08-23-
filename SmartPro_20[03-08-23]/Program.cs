using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_20_03_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _username = "Lesponns", _username_inp;
            string _password = "ZeroSix", _password_inp;

            do
            {
                Console.WriteLine("Login Interface");
                Console.WriteLine(" ");

                Console.Write("UserName: ");
                _username_inp = Console.ReadLine();

                Console.Write("Password: ");
                _password_inp = Console.ReadLine();
                Console.Clear();
            } while (_username_inp != _username || _password_inp != _password);

            Console.WriteLine("Welcome, " + _username_inp);

            Console.ReadKey();
            
        }
    }
}