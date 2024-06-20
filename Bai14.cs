using System;
using System.Text;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float x;

            x = ReadFloatInput();

            Console.WriteLine($"Entered value: {x}");
        }

        static float ReadFloatInput()
        {
            float inputFloat;
            while (true)
            {
                Console.Write("Enter a 4-byte floating-point number: ");
                string input = Console.ReadLine();

                if (float.TryParse(input, out inputFloat))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            return inputFloat;
        }
    }
}
