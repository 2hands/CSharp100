using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome_Checker
{
    class Program
    {
        static string str, temp, strt;
        static char ltr;
        static int strleng, j;

        static void Main()
        {
            Console.WriteLine("Enter a string to test ");
            str = Console.ReadLine();
            int min = 0;
            int max = str.Length - 1;
            int count = str.Length - 1;
            for (int i = 0; i < count; i++ )
            {
            {
                if (min > max)
                {
                    Console.Write(str);
                    Console.WriteLine(" is a palindrome");
                    count = 0;
                }
                char a = str[min];
                char b = str[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    Console.Write(str);
                    Console.WriteLine(" is not a palindrome");
                    count = 0;
                }
                min++;
                max--;
            }
        }
            //just to keep the cmdline from closing
            string tch = Console.ReadLine();
        }

        //static void Main()
        //{
        //    Console.Write("Enter a string to checked: ");
        //    string str = Console.ReadLine();
        //    temp = String.Copy(str);
        //    j = str.Length;
        //    //temp = string.Copy(str);
        //    for (int i = 0; i < j; i++)
        //    {
        //        j--;
        //        ltr = str[i];
        //        temp[j] = ltr;
        //        //temp[strleng] = ltr;
        //    }
        //        Console.Write(strleng);
        //    Console.Write(str[3]);
        //}

    }
}
