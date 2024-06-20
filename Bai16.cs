using System;

namespace Bai16
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            byte m = ReadUnsignedByteInRange("Enter the number of rows (m) between 2 and 10: ", 2, 10);
            byte n = ReadUnsignedByteInRange("Enter the number of columns (n) between 2 and 10: ", 2, 10);
            Console.WriteLine($"You entered m = {m}, n = {n}");

            int[,] a = new int[m, n];

            Console.WriteLine($"Enter {m * n} integer values:");
            ReadIntArray(a);

            Console.WriteLine("The values in array a are:");
            PrintIntArray(a);

            int sumDivisibleBy2024 = SumOfElementsDivisibleBy(a, 2024);
            Console.WriteLine($"The sum of the elements in the array that are divisible by 2024 is: {sumDivisibleBy2024}");
        }

        static byte ReadUnsignedByteInRange(string prompt, byte min, byte max)
        {
            byte result;
            bool isValid;
            do
            {
                Console.Write(prompt);
                isValid = byte.TryParse(Console.ReadLine(), out result) && result >= min && result <= max;
                if (!isValid)
                {
                    Console.WriteLine($"Invalid input. Please enter an integer between {min} and {max}.");
                }
            } while (!isValid);
            return result;
        }

        static int ReadInt(string prompt)
        {
            int result;
            bool isValid;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out result);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a 4-byte integer.");
                }
            } while (!isValid);
            return result;
        }

        static void ReadIntArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ReadInt($"Enter value for element [{i}, {j}]: ");
                }
            }
        }

        static void PrintIntArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int SumOfElementsDivisibleBy(int[,] array, int p)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % p == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
