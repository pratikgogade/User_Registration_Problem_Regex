using System;
using System.Text.RegularExpressions;//namespace for regex
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("User Registration Problem using REGEX");
                Console.WriteLine("1.First Name");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FirstName firstName = new FirstName();
                        firstName.First();
                        break;
                    default:
                        flag = false;
                        break;

                }
            }
        }

    }
}