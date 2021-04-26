using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationTest
{
   public class HandleException:Exception
    {
       
            public enum ExceptionType
            {
                ENTERD_NULL_EXCEPTION,
                ENTERD_EMPTY_EXCEPTION,
                IVALID_INPUT,
                INVALID_FIRSTNAME,
                INVALID_LASTNAME,
                INVALID_PASSWORD,
                INVALID_EMAIL_ID,
                INVALID_MOBILE_NUMBER
            }

            
            ExceptionType type;
            readonly string message;

            public HandleException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
                this.message = message;
            }
        }
    }




