using System;

namespace Bai15
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            byte n = ReadUnsignedByteInRange("Enter a number between 2 and 10: ", 2, 10);
            Console.WriteLine($"You entered n = {n}");

            float[] a = new float[n];

            Console.WriteLine($"Enter {n} float values:");
            ReadFloatArray(a);

            // Step 4: Display the values of array a in a single horizontal line
            Console.WriteLine("Values entered in array a:");
            PrintFloatArray(a);
        }

        static byte ReadUnsignedByteInRange(string prompt, byte min, byte max)
        {
            byte result;
            bool isValid = false;
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

        static void ReadFloatArray(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isValid = false;
                do
                {
                    Console.Write($"Enter value #{i + 1}: ");
                    isValid = float.TryParse(Console.ReadLine(), out array[i]);
                    if (!isValid)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid floating-point number.");
                    }
                } while (!isValid);
            }
        }

        static void PrintFloatArray(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine(); 
        }
    }
}
