//Make sure key is 0 to 25
//Stop being lazy and shift elements in the array instead of creating an offset

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        //variables
        static int choice;
        static char[] alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static char[] alphaLower = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyza".ToCharArray();
        static string message;
        static int strlen;
        static char choice2;

        static void Main()
        {
            Console.WriteLine("Would like to encode (1) or decipher (2)? Press 1 or 2");
            choice = Console.Read();
            if (choice == '1')
            {
                encode();
                resume();
            }
            else if (choice == '2')
            {
                decipher();
                resume();
            }
            else
            {
                Console.WriteLine("That is not a choice please try again");
            }
        }

        //function to encode a message
        static void encode()
        {
            Console.Write("Write a message to encode: ");
            Console.ReadLine();
            message = Console.ReadLine();
            Console.WriteLine("Enter a key(Integer between 0-25): ");
            int key = int.Parse(Console.ReadLine());
            strlen = message.Length;
            char[] newmessage = new char [strlen];
            for (int i = 0; i <= strlen - 1; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (message[i] == alphaUpper[j])
                    {
                        newmessage[i] = alphaUpper[j + key];
                    }
                    else if (message[i] == alphaLower[j])
                    {
                        newmessage[i] = alphaLower[j + key];
                    }
                    else
                    { }
                }
            }
            Console.WriteLine(newmessage);
        }
        //function to decipher a message
        static void decipher()
        {
            Console.Write("Write a message to decode: ");
            Console.ReadLine();
            message = Console.ReadLine();
            Console.WriteLine("Enter a key(Integer between 0-25): ");
            int key = int.Parse(Console.ReadLine());
            strlen = message.Length;
            char[] newmessage = new char[strlen];
            for (int i = 0; i <= strlen - 1; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (message[i] == alphaUpper[j])
                    {
                        newmessage[i] = alphaUpper[26 + j - key];
                    }
                    else if (message[i] == alphaLower[j])
                    {
                        newmessage[i] = alphaLower[26 + j - key];
                    }
                    else
                    { }
                }
            }
            Console.WriteLine(newmessage);
        }
        //function to ask if you want to continue
        static void resume()
        {
            Console.WriteLine("Would you like to continue? (Y/N)");
            choice2 = char.Parse(Console.ReadLine());
            if(choice2 == 'Y' | choice2 == 'y')
            {
                Main();
            }
            else if (choice2 == 'N' | choice2 == 'n')
            {

            }
            else
            {
                Console.WriteLine("Select Y or N");
                resume();
            }
        }
    }
}
