using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collatz_Conjecture
{
    class Program
    {
        static int num,test,k;
        static int j = -1;
        
        static void Main(string[] args)
        {
            Console.Write("Enter a number you want to apply Collatz Conjecture to (Must be an integer) ");
            num = int.Parse(Console.ReadLine());
            calc();
        }
        static void calc()
        {
            for (int i = 0; i > j; i++)
            {
                
                test = num % 2;
                if (test == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }

                //check if the loop needs to continue
                if (num == 1)
                {
                    k = i + 1;
                    j = i + 1;
                    exit();
                }
            }
        }
        static void exit()
        {
            Console.WriteLine("The amount of steps to reach one is " + k);

        }
    }
}
