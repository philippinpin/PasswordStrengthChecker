using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            string result = CheckPasswordStrength(password);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string CheckPasswordStrength(string password)
        {
          
            int minLength = 8;

          
            if (password.Length < minLength)
            {
                return "Weak Password:Your password must be at least 8 characters long.";
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return "Weak Password: Your password must contain at least one uppercase letter.";
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return "Weak Password: Your password must contain at least one lowercase letter.";
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                return "Weak Password: Your password must contain at least one digit.";
            }

            if (!Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]"))
            {
                return "Weak Password:Your password must contain at least one special character.";
            }

            return "Strong Password: Your password met all the criteria";
        }
    }
}
