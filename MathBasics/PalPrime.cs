using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBasics
{
    internal class PalPrime
    {
        public static void Palindrome(int input) 
        {
            int output = Reverse.revNumb(input);

            if (input == output) 
            { 
                Console.WriteLine(input+" is a palindrome.");
            }
            else
            {
                Console.WriteLine(input + " is not a palindrome."); 
            }
        }

        public static void Prime( int n)
        {
            int factorCount = 0;

            for (int i = 1; i <=n; i++)
            {
                if (n % i == 0)
                { 
                    factorCount++;
                }
            }

            if (factorCount == 2)
            {
                Console.WriteLine(n + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(n + " is not a Prime Number.");
            }
        }

        public static void PrimeCheck(int n)
        {
            for (int i = 0; i <= n; i++) 
            {
                Prime(i);
            }
        }
    }
}
