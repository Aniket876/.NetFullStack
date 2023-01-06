using System;

namespace Assignment1_Q3
{
    class Program
    {
        public static int sum(params int [] arr)
        {
            int final_sum = 0;
            foreach(int i in arr)
            {
                final_sum += i;
            }
            return final_sum;
        }
        public static void Main(string[] args)
        {
            int n = sum(17, 13, 14, 15, 80);
            Console.WriteLine("the sum of the numbers are {0}", n);
        }
    }
}
