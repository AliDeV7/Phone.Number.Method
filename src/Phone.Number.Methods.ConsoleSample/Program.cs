using PhoneNumber.Methods;
using System;

namespace Phone.Number.Methods.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = PhoneNumberMethod.GetCorrectPhoneNumber("9afadasdsa370692219");
            if (result.IsSuccess)
            {
                Console.WriteLine($"{result.CorrectPhoneNumber}");
                Console.WriteLine($"{result.Country.Name}");
                Console.WriteLine($"{result.Country.ISO}");
                Console.WriteLine($"{result.Country.Code}");
                Console.WriteLine($"{result.Status}");
            }
            else
            {
                Console.WriteLine($"{result.Message}");
            }
            Console.ReadKey();
        }
    }
}
