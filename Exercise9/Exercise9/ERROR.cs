using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public static class ERROR
    {
        public static string CheckSsn()
        {
            Console.WriteLine();
            long ssn = 0;
            string realSsn = "";
            bool go = true;

            do
            {
                if (!long.TryParse(Console.ReadLine(), out ssn)) { Console.WriteLine("Not a Valid Number\nTyr again. . ."); }
                else
                {
                    realSsn = ssn.ToString();
                    if (realSsn.Length == 10)
                    {
                        go = false;
                    }
                    else { Console.WriteLine("You need 10 numbers! Example 8503103845\nTry again. . ."); }
                }     
            } while (go);

            return realSsn;
        }
        public static string NameCheck()
        {
            bool go = true;
            double test = 0;

            do
            {
                if (double.TryParse(Console.ReadLine(), out test)) { Console.WriteLine("You cant put numbers in your name!\nTry again. . ."); }
                else { go = false; }
            } while (go);

            string name = test.ToString();
            return name;
        }
        public static string NumberCheckString()
        {
            bool go = true;
            int number = 0;
            string CheckedNr = string.Empty;
            do
            {

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number == 0) { Console.WriteLine($"Employee cant have {number} as wage!\nTry again. . .");  }
                    else { go = false; }
                }
                else{ Console.WriteLine("Must write a number!\nTry again. . ."); }
            } while (go);

            CheckedNr = Convert.ToString(number);
            return CheckedNr;
        }
        public static int NumberCheckInt()
        {
            bool go = true;
            int number = 0;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out number)) { Console.WriteLine("Must write a number!\nTry again. . ."); }
                else
                {
                    if (number == 0) { Console.WriteLine($"Employee cant have {number} as wage!\nTry again. . ."); }
                    else { go = false; }
                }
            } while (go);
            return number;
        }
    }
}
