// Does not return dollar amounts in change
// Does not error check if item cost is higher than given tender
// Does not round up cchange

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Change_Return
{
    class Program
    {
        // declared variables
        static double itemcost, tender, change, cchange, ochange;
        static int qtr, dime, nic, pen;

        static void Main()
        {
            Console.Write("Please enter the item cost: $");
            itemcost = double.Parse(Console.ReadLine());
            Console.Write("Now please enter your tender: $");
            tender = double.Parse(Console.ReadLine());
            change = tender - itemcost;
            cchange = change % 1;
            calcq();
        }

        static void calcq()
        {
            ochange = cchange;
            // Formulas for calculating quaters
            for (int i = 1; i > 0; i++)
            {
                cchange = cchange - .25;
                if (cchange >= 0)
                {
                    qtr++;
                }
                else
                {
                    cchange = ochange - (qtr * .25);
                    calcd();
                }
            }

        }
        static void calcd()
        {
            ochange = cchange;
            // Formulas for calculating dimes
            for (int i = 1; i > 0; i++)
            {
                cchange = cchange - .10;
                if (cchange >= 0)
                {
                    dime++;
                }
                else
                {
                    cchange = ochange - (dime * .10);
                    calcn();
                }
            }
        }

        static void calcn()
        {
            ochange = cchange;
            // Formulas for calculating dimes
            for (int i = 1; i > 0; i++)
            {
                cchange = cchange - .05;
                if (cchange >= 0)
                {
                    nic++;
                }
                else
                {
                    cchange = ochange - (nic * .05);
                    calcp();
                }
            }
        }

        static void calcp()
        {
            ochange = cchange;
            // Formulas for calculating dimes
            for (int i = 1; i >= 0; i++)
            {
                cchange = cchange - .01;
                if (cchange > 0)
                {
                    pen++;
                }
                else
                {
                    cchange = ochange - (pen * .01);
                    disp();
                }
            }
        }

        static void disp()
        {
            Console.WriteLine("Your change is: ");
            Console.Write("Quarter(s): ");
            Console.WriteLine(qtr);
            Console.Write("Dime(s): ");
            Console.WriteLine(dime);
            Console.Write("Nickel(s): ");
            Console.WriteLine(nic);
            Console.Write("Penny(s): ");
            Console.WriteLine(pen);
            
            
            // Tenporary
            Main();
            // Add exit statement
            Console.ReadLine();
        }
    }
}