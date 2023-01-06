using System;

namespace Assignment1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks");
            float[] arr = new float[5];
            float f;
            for (int i = 0; i < 5; i++)
            {
                f = Single.Parse(Console.ReadLine());
                arr[i] = f;
            }
            float highest = arr[0];
            for (int i = 1; i < 5; i++)
            {
                if (highest < arr[i])
                {
                    highest = arr[i];
                }
            }
            Console.WriteLine("highest marks is "+highest);
        }
    }
}
