using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci_Sequence
{
    class Program
    {
        static int cur = 1;
        static int prev = 0;
        static int temp;
        static void Main(string[] args)
        {
            Console.Write("How many times would you like to calculate the fibonacci sequence? (Up to 46) ");
            int count = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < count; i++ )
            {
                Console.WriteLine(i + ". " + prev);
                temp = cur + prev;
                prev = cur;
                cur = temp;
            }
        }
    }
}
