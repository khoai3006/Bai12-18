using System;

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string st = Console.ReadLine();

            if (st == "#")
            {
                Console.Beep();
            }
            else
            {
                int wordCount = CountWords(st);
                Console.WriteLine("The number of words in the string is: " + wordCount);
            }
        }

        static int CountWords(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            string[] words = str.Split(new char[] { ' ', '.', '!', '?', ',', ';', ':', '-', '_', '/', '\\', '@', '#', '$', '%', '^', '&', '*', '(', ')', '[', ']', '{', '}', '"', '\'', '|', '<', '>', '~', '`', '+', '=', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }
    }
}
