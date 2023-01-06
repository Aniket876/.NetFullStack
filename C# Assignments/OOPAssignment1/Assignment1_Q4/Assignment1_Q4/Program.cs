using System;

namespace Assignment1_Q4
{
    class Program
    {
        public static void swap(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("the swap numbers are {0} and {1}", a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            swap(a, b);
        }
    }
}
