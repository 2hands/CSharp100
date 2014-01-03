using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reversing_Strings
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string to be reversed");
            string str = Console.ReadLine();
            Console.WriteLine("String length is: " + str.Length);
            int x = str.Length - 1;
            int y = str.Length;
            Console.Write("The reversed string is: ");
            for (int i = 0; i < y; i++)
            {
                char ltr = str[x];
                Console.Write(ltr);
                --x;
            }
            Console.WriteLine();
        }
    }
}
