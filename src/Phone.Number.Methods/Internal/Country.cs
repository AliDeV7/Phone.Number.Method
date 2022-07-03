using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber.Methods.Internal
{
    public class Country
    {
        public string Name { get; set; }
        /// <summary>
        ///  Country Phone Number Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///  ISO 3166 - Alpha 2 Country Code
        /// </summary>
        public string ISO { get; set; }
    }
}
