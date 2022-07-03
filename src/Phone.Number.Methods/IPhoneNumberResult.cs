using PhoneNumber.Methods.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber.Methods
{
    public enum PhoneNumberResultStatus
    {
        Success,
        Failed
    }

    public interface IPhoneNumberResult
    {
        /// <summary>
        /// Default Phone Number Result
        /// ISO + Phone Number
        /// e.x : 98937*******
        /// </summary>
        string CorrectPhoneNumber { get; }

        Country Country { get; }

        PhoneNumberResultStatus Status { get; }
        string Message { get; }

        bool IsSuccess { get; }
    }
}
