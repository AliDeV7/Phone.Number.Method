using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace PhoneNumber.Methods.Internal
{
    public static class CountryCodeHelper
    {
        private const string JsonPath = "\\src\\Phone.Number.Methods\\CountryPhoneNumber.json";

        public static bool IsCodeExist(string countryCode)
        {
            var JsonFolderPath = Directory.GetCurrentDirectory().Split("\\src")[0].ToString() + JsonPath;
            return JsonConvert.DeserializeObject<List<Country>>(File.ReadAllText(JsonFolderPath)).Any(x => x.Code == countryCode);
        }

        public static Country GetCountryByCode(string countryCode)
        {
            var JsonFolderPath = Directory.GetCurrentDirectory().Split("\\src")[0].ToString() + JsonPath;
            return JsonConvert.DeserializeObject<List<Country>>(File.ReadAllText(JsonFolderPath)).FirstOrDefault(x => x.Code == countryCode);
        }
    }
}
