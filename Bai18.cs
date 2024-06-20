using System;

namespace Bai18
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double x = ReadDoubleFromConsole();

            double squareRoot = Math.Sqrt(x);
            Console.WriteLine($"Square root of {x} is: {squareRoot}");
        }

        static double ReadDoubleFromConsole()
        {
            double result;
            bool isValidInput = false;

            do
            {
                Console.Write("Enter a double precision number (8 bytes): ");
                string input = Console.ReadLine();

                isValidInput = double.TryParse(input, out result);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid double precision number.");
                }

            } while (!isValidInput);

            return result;
        }
    }
}
