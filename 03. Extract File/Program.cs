using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");

            string[] lastFile = input[input.Length-1].Split(".");

            Console.WriteLine($"File name: {lastFile[0]}");
            Console.WriteLine($"File extension: {lastFile[1]}");
        }
    }
}
