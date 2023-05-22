using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_number_changer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer in decimal: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid integer provided.");
                return;
            }

            Console.Write("Enter the new base number system (2-20): ");
            if (!int.TryParse(Console.ReadLine(), out int newBase) || newBase < 2 || newBase > 20)
            {
                Console.WriteLine("Invalid base number system provided. It should be between 2 and 20.");
                return;
            }

            string convertedNumber = ConvertToBase(number, newBase);
            Console.WriteLine("Converted number: " + convertedNumber);
            Console.ReadLine();
        }

        static string ConvertToBase(int number, int newBase)
        {
            string digits = "0123456789ABCDEFGHIJ";
            string converted = "";

            if (number == 0)
                return "0";

            while (number > 0)
            {
                int remainder = number % newBase;
                converted = digits[remainder] + converted;
                number /= newBase;
            }

            return converted;
        }
    }
}
