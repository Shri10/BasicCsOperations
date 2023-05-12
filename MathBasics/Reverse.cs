using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBasics
{
    internal class Reverse
    {
        public static String ReverseWord(String word)
        {
            String rev = "";
            foreach (char c in word)
            {
                rev = c + rev;
            }
            //Console.WriteLine(rev);
            return rev;
        }

        public static void ReverseWordInOrder(String sent) 
        {
            string rev = "";
            char[] delimeters = { ' ', ',', ':' };
            string[] words = sent.Split(delimeters);
            foreach (string w in words)
            {
                string r = ReverseWord(w);
            }
            Console.WriteLine(rev);
        }

        public static int revNumb(int n)
        {
            int remainder = 0 , reverse = 0 ;
            while (n != 0)
            {
                remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n = n /10;
            }
            return reverse;
//            return Console.WriteLine(reverse);
        }

        /*        public static void Palindrome(int n)
                {
                    int output =
                }
        */


    }
}
