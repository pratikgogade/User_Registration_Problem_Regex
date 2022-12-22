using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Password
    {
        public void Pass()
        {
            Console.WriteLine("Enter User Password");
            var data = Console.ReadLine();
            string pattern = "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It Is A Valid Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It Is An Invalid Password");
                Console.ResetColor();
            }
        }
    }
}