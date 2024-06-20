using System;
using System.Text;

namespace Bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Em khong hieu cai dong Tieng viet nay la gi 

            byte n;

            n = ReadByteInput();

            Console.WriteLine($"Entered value: {n}");
        }

        static byte ReadByteInput()
        {
            byte inputByte;
            while (true)
            {
                Console.Write("Enter an unsigned 1-byte integer (2-10): ");
                string input = Console.ReadLine();

                if (byte.TryParse(input, out inputByte) && inputByte >= 2 && inputByte <= 10)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            return inputByte;
        }
    }
}
