using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class PhoneNumber
    {
        public void PhnNum()
        {
            Console.WriteLine("Enter Mobile Number");
            var data = Console.ReadLine();
            string pattern = "^[+][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It Is A Valid Phone Number");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It Is An Invalid Phone Number");
                Console.ResetColor();
            }
        }
    }
}