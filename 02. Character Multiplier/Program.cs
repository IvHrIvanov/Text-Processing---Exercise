using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstWord = input[0];
            string secondWod = input[1];

            string longWord = firstWord;
            string shortWOrd = secondWod;
            
            if(firstWord.Length<secondWod.Length)
            {
                longWord = secondWod;
                shortWOrd = firstWord;
            }

            int totalSUm = CharManipulater(longWord, shortWOrd);
            Console.WriteLine(totalSUm);

        }
        public static int CharManipulater(string longWord, string shortWord)
        {
            int sum = 0;
            for (int i = 0; i < shortWord.Length; i++)
            {
                int multiply = longWord[i] * shortWord[i];
                sum += multiply;
            }
            for (int i = shortWord.Length; i < longWord.Length; i++)
            {
                sum += longWord[i];
            }
            return sum;
        }
        
    }
}
