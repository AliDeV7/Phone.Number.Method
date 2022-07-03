using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PhoneNumber.Methods.Internal
{
    internal static class PhoneNumberHelper
    {
        /// <summary>
        /// Set Default Country code
        /// if phonenumber is less than 10 digits, use this Country as e default country code
        /// </summary>
        private static string DefaultCountryCode = "98";

        /// <summary>
        /// Check if input Phone Number is Correct Or Not 
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>True | False</returns>
        public static bool IsPhoneNumberFormatCorrect(string phoneNumber)
        {
            try
            {
                return Regex.Match(phoneNumber, @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$").Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Convert Persian or Arabic numbers to Englisih number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private static string ToEnglishNumber(string phoneNumber)
        {
            string EnglishNumbers = "";

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (Char.IsDigit(phoneNumber[i]))
                {
                    EnglishNumbers += char.GetNumericValue(phoneNumber, i);
                }
                else
                {
                    EnglishNumbers += phoneNumber[i].ToString();
                }
            }
            return EnglishNumbers;
        }


        /// <summary>
        /// Check if entered phone number is correct or not
        /// check country code, and phone number Scheme
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static PhoneNumberResult CorrectPhoneNumber(string phoneNumber)
        {
            if (!IsPhoneNumberFormatCorrect(phoneNumber))
                return PhoneNumberResult.Failed("Phone number Format is not correct");

            phoneNumber = phoneNumber.Replace("-", "");
            phoneNumber = phoneNumber.Replace("_", "");
            phoneNumber = phoneNumber.Replace("+", "");
            phoneNumber = ToEnglishNumber(phoneNumber);

            if (phoneNumber.StartsWith("00"))
                phoneNumber = phoneNumber.Remove(0, 2);

            if (phoneNumber.StartsWith("0"))
                phoneNumber = phoneNumber.Remove(0, 1);

            if (phoneNumber.Length > 10)
            {
                //Get 10 digit from end of number
                string phoneNumberWithoutCode = phoneNumber.Substring(phoneNumber.Length - 10);

                string countryCode = phoneNumber.Split(phoneNumberWithoutCode)[0];
                if (!CountryCodeHelper.IsCodeExist(countryCode))
                    return PhoneNumberResult.Failed($"Country code : {countryCode} Is not exist");

                return PhoneNumberResult.Succeed(phoneNumber, CountryCodeHelper.GetCountryByCode(countryCode));
            }
            else if (phoneNumber.Length == 10)
            {
                // Set Default for IRAN
                return PhoneNumberResult.Succeed(DefaultCountryCode + phoneNumber, CountryCodeHelper.GetCountryByCode(DefaultCountryCode));
            }

            else
                return PhoneNumberResult.Failed($"Phone Number digits : {phoneNumber.Length} is Incorrect");

        }
    }
}
