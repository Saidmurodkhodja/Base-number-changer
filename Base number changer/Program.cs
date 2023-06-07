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
            if (!int.TryParse(Console.ReadLine(), out int number)) // checks if input is an integer
            {
                Console.WriteLine("Invalid integer provided.");
                return; // stops the program if input is not an integer
            }

            Console.Write("Enter the new base number system (2-20): ");
            if (!int.TryParse(Console.ReadLine(), out int newBase) || newBase < 2 || newBase > 20)
            {
                Console.WriteLine("Invalid base number system provided. It should be between 2 and 20."); // checks if input is between 2 and 20
                return; // stops the program if input is not between 2 and 20
            }

            string convertedNumber = ConvertToBase(number, newBase); // uses the method to convert number according to the base
            Console.WriteLine("Converted number: " + convertedNumber);
            Console.ReadLine();
        }

        static string ConvertToBase(int number, int newBase)
        {
            string digits = "0123456789ABCDEFGHIJ"; // list of base numbers till 20th
            string converted = "";

            if (number == 0)
                return "0";

            while (number > 0)
            { // loop using formula to convert the number from one number base to another
                int remainder = number % newBase; 
                converted = digits[remainder] + converted;
                number /= newBase;
            }

            return converted;
        }
    }
}
