using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBasics
{
    internal class Calculator
    {
        public void AddNumbs(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Addition\tof given numbers is:\t" + sum);
        }

        public void SubNumbs(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("Subtraction\tof given numbers is:\t" + sub);
        }

        public void MulNumbs(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("Multiplication\tof given numbers is:\t" + mul);
        }

        public void DivNumbs(int x, int y)
        {
            if (y != 0)
            {
                int div = x / y;
                Console.WriteLine("Division\tof given numbers is:\t" + div);
            }
            else
            { 
                Console.WriteLine("Make sure the 2nd number is NOT Zero");
            }
        }


    }
}
