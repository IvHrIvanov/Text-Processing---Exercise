using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = string.Empty;
            foreach (var item in input)
            {

                output += (char)(item + 3);

            }
            Console.WriteLine(output);
        }
    }
}
