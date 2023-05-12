using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBasics
{
    internal class Fibbo
    {
        public static void generateFibo(int n)
        {
            int n1 = 0, n2 = 1, sum = 0;

            Console.WriteLine("Printing Fibonacci series till "+n+" numbers.");

            if (n == 1)
            {
                Console.WriteLine(n1);
            }
            else if (n == 2) 
            {
                Console.WriteLine(n1 + " " +n2);
            }
            else
            {
                Console.WriteLine(n1 + " " +n2);
                for (int i = 3; i <= n; i++)
                {
                    sum = n1 + n2;
                    Console.WriteLine(" "+sum);
                    n1 = n2;
                    n2 = sum;
                }
            }

        }
    }
}
