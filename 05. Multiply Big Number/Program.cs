using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiply = int.Parse(Console.ReadLine());
            int temp = 0;
            StringBuilder sb = new StringBuilder();
            if (multiply == 0 || number =="")
            {
                Console.WriteLine(0);
                return;
            }
            foreach (var cur in number.Reverse())
            {
                int digit = int.Parse(cur.ToString());
                int result = digit * multiply+temp;
                int restDigit = result % 10;
                temp = result / 10;

                sb.Insert(0,restDigit);
            }

            if(temp>0)
            {
                sb.Insert(0, temp);
            }

            Console.WriteLine(sb);
        }
    }
}
