using PhoneNumber.Methods.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber.Methods
{
    /// <summary>
    /// Describes phone number result status.
    /// </summary>
    public enum PhoneNumberResultStatus
    {
        /// <summary>
        /// Request for Rhonenumber was successful.
        /// </summary>
        Success,

        /// <summary>
        /// Request for Rhonenumber was failed.
        /// </summary>
        Failed
    }

    /// <summary>
    /// Describes the result of the get Phone Number request.
    /// </summary>
    public interface IPhoneNumberResult
    {
        /// <summary>
        /// Phone Number Result
        /// ISO + Phone Number
        /// e.x : 98937*******
        /// </summary>
        string CorrectPhoneNumber { get; }

        /// <summary>
        /// If result is successful, this property returns full country details.
        /// </summary>
        Country Country { get; }

        /// <summary>
        ///  Describe phone number request status.
        /// </summary>
        PhoneNumberResultStatus Status { get; }

        /// <summary>
        /// If request phone number was failed, message explain why.  
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Describe request result for phone number. 
        /// </summary>
        bool IsSuccess { get; }
    }
}
