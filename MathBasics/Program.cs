namespace MathBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, Welcom to basic C# program!\nPlease Choose from the following Options:\n\t");
            Console.WriteLine("\t1. Perform Basic Mathematics Operations.\r\n\t2. Generate Fibonacci series within given Range.\r\n\t3. Reverse given String.\r\n\t4. Reverse a Statement in its original order.\r\n\t5. Please enter number to make reverse. \r\n\t6. Check if given Number is Palindrome.\r\n\t7. Check if given number is Prime number.\r\n\t8. Generate Prime numbers within given Range.\r\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine("Please Select a Valid Option.");
                    break;
                case 1:
                    //Calc
                    Calculator calc = new Calculator();
                    Console.WriteLine("Please enter 1st Number: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter 2nd Number: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Basic Math Operations on numbers: " + x + " & " + y);

                    calc.AddNumbs(x, y);
                    calc.SubNumbs(x, y);
                    calc.MulNumbs(x, y);
                    calc.DivNumbs(x, y);
                    break;
                case 2:
                    //Fibo
                    Console.WriteLine("To Generate Fibonacci series within given Range, Please enter the Range:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n < 47)
                    {
                        Fibbo.generateFibo(n); // WHY
                    }
                    else
                    {
                        Console.WriteLine("Enter a number till 46.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter any one word to reverse it:");
                    string word = Console.ReadLine();
                    Console.WriteLine("After reverse the word is: "+Reverse.ReverseWord(word));
                    break;
                case 4:
                    Console.WriteLine("Enter any statement to reverse it IN its order:");
                    string sen = Console.ReadLine();
                    Reverse.ReverseWordInOrder(sen);
                    break;
                case 5:
                    Console.WriteLine("Enter a number to reverse it:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("After reverse the word is: " + Reverse.revNumb(x));
                    break;
                case 6:
                    Console.WriteLine("Enter a number to check if its a Palindrome or not:");
                    x = Convert.ToInt32(Console.ReadLine());
                    PalPrime.Palindrome(x);
                    break;
                case 7:
                    Console.WriteLine("Enter a number to check if its a Prime number or not:");
                    x = Convert.ToInt32(Console.ReadLine());
                    PalPrime.Prime(x);
                    break;
                case 8:
                    Console.WriteLine("To Check range of numbers, for whether they are prime or not, Please enter a number:");
                    x = Convert.ToInt32(Console.ReadLine());
                    PalPrime.PrimeCheck(x);
                    break;
                default:
                    Console.WriteLine("Please Select a Valid Option.");
                    break;
            }

        }
    }
}