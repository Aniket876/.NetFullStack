using System;

namespace Assignment1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the operation you want to perform");
            Console.WriteLine("1 for addition,2 for subtraction,3 for multiplication,4 for division");
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            switch (n)
            {
                case 1:
                {
                    ans = a + b;
                    Console.WriteLine($"sum is {ans}");
                    break;
                }
                case 2:
                {
                        ans = Math.Abs(a - b);
                        Console.WriteLine("subtraction is {0}", ans);
                        break;
                }
                case 3:
                {
                        ans = a * b;
                        Console.WriteLine("multiplication is {0}", ans);
                        break;
                }
                case 4:
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("division is not possible, b is equal to zero");
                            break;
                        }
                        ans = a / b;
                        Console.WriteLine("division is {0}", ans);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid operation");
                        break;
                    }
            }
        }
    }
}
