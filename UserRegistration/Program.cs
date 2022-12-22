using System;
using System.Text.RegularExpressions;
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
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email Address\n4.Phone Number\n5.Password");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FirstName firstName = new FirstName();
                        firstName.First();
                        break;
                    case 2:
                        LastName lastName = new LastName();
                        lastName.Last();
                        break;
                    case 3:
                        EmailAddress email = new EmailAddress();
                        email.Email();
                        break;
                    case 4:
                        PhoneNumber phoneNumber = new PhoneNumber();
                        phoneNumber.PhnNum();
                        break;
                    case 5:
                        Password1 password1 = new Password1();
                        password1.Pass();
                        break;
                    default:
                        flag = false;
                        break;

                }
            }
        }

    }
}