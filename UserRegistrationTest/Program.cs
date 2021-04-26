using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserRegistrationTest
{
   public class Program
    {
        static void Main(string[] args)
        {
            UserDetailsPattern pattern = new UserDetailsPattern();
            Console.WriteLine("====================Welcome To User Registration Program=======================");

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateFirstName(firstName));

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateLastName(lastName));

            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            Console.WriteLine(pattern.ValidateEmail(emailID));

            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine(pattern.ValidatePassword(password));
        }
    }
}
