using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
   public class UserDetailsPattern
    {
        //Regular expression patterns for name,email,mobile number and password.
        public static string namePattern = "^[A-Z][a-z]{2,}$";
        public static string mailIDPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";
        public static string mobileNumberPattern = "^[1-9]{2}[ ][0-9]{10}";
        public static string passwordPattern = "(?=.*[A-Z]{1,})(?=.*[a-z]{1,})(?=.*[0-9]{1,})(?=.*[@#$%+!]{1}).{8,}";

        //Validation of  all the details
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, namePattern) ? "Valid First Name" :
           throw new HandleException(HandleException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");

        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid Last Name" :
           throw new HandleException(HandleException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");

        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid mailID" :
           throw new HandleException(HandleException.ExceptionType.INVALID_EMAIL_ID, "Invalid email id");

        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid mobile number" :
           throw new HandleException(HandleException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number");

        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
           throw new HandleException(HandleException.ExceptionType.INVALID_PASSWORD, "Invalid password");
    }
}

