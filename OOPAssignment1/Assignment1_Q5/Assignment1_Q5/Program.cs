using System;

namespace Assignment1_Q5
{
    class Program
    {
        public static void Calculate(ref double area, ref double circumference, ref double  r)
        {
            const double pi = 3.14;
            area = pi * r * r;
            circumference = 2 * pi * r;
        }
        static void Main(string[] args)
        {
            double area = 0;
            double circumference = 0;
            Console.WriteLine("enter the radius");
            double r = Convert.ToDouble(Console.ReadLine());
            Calculate(ref area, ref circumference, ref r);
            Console.WriteLine("the area of circle is {0}", area);
            Console.WriteLine("the circumference of circle is {0}", circumference);

        }
    }
}
