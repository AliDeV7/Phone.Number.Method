using PhoneNumber.Methods.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber.Methods
{
    public static class PhoneNumberMethod
    {
        public static IPhoneNumberResult GetCorrectPhoneNumber(string phoneNumber)
        {
           return PhoneNumberHelper.CorrectPhoneNumber(phoneNumber);
        }
    }
}
