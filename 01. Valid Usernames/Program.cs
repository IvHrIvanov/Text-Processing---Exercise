using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            List<string> output = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];

                if(isValid(currentName))
                {
                    Console.WriteLine(currentName);
                }
            }
         
        }
        public static bool isValid(string current)
        {

            return current.Length >= 3 &&
                current.Length <= 16 &&
                current.All(c => char.IsLetterOrDigit(c)) ||
                current.Contains("-") || current.Contains("_");
        }
    }
}