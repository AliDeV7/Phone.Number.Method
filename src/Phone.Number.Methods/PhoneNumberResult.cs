using PhoneNumber.Methods.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber.Methods
{
    public class PhoneNumberResult : IPhoneNumberResult
    {
        public string CorrectPhoneNumber { get; set; }

        public Country Country { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public PhoneNumberResultStatus Status { get; set; } = PhoneNumberResultStatus.Success;

        /// <summary>
        /// Creates an instance of <see cref="PhoneNumberResult"/> which indicates a successful result for correct phone number.
        /// </summary>
        /// <param name="correctPhoneNumber"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public static PhoneNumberResult Succeed(string correctPhoneNumber,Country country)
        {
            return new PhoneNumberResult()
            {
                CorrectPhoneNumber = correctPhoneNumber,
                Country = country,
                IsSuccess = true
            };
        }

        /// <summary>
        /// Creates an instance of <see cref="PhoneNumberResult"/> which indicates a failure result.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static PhoneNumberResult Failed(string message)
        {
            return new PhoneNumberResult()
            {
                Status = PhoneNumberResultStatus.Failed,
                Message = message,
                IsSuccess = false
            };
        }
    }
}
