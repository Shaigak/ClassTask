using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account

    {
        public string name;
        public string password;

        public Account(string name, string password)
        {
            this.name = name;
            this.password = password;
        }


        internal void Sign()
        {
            if (name == "Cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password yanlisdir");
            }
        }
    }
}




