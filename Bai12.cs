using System;
using System.Text;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ushort n;

            n = ReadUShortFromConsole();

            Console.WriteLine($"The value you just input: {n}");

            ulong sumOfSquares = CalculateSumOfSquares(n);

            Console.WriteLine($"sum of squares from 1 to {n}: {sumOfSquares}");
        }

        static ushort ReadUShortFromConsole()
        {
            ushort number;
            bool isValid;

            do
            {
                Console.Write("Input a 2 byte number (0 to 65535): ");
                string input = Console.ReadLine();
                isValid = ushort.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("Invalid value. Please reenter a number.");
                }
            } while (!isValid);

            return number;
        }

        static ulong CalculateSumOfSquares(ushort n)
        {
            ulong sum = 0;
            for (ushort i = 1; i <= n; i++)
            {
                sum += (ulong)i * i;
            }
            return sum;
        }
    }
}
