using System;

namespace OOPAssignment3_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack m1 = new MyStack();
            int i;
            do
            {
                Console.WriteLine("enter the operation you want to perform");
                Console.WriteLine("1 for push");
                Console.WriteLine("2 for pop");
                Console.WriteLine("3 for print");
                Console.WriteLine("4 for cloning");
                Console.WriteLine("5 for exit");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("enter the value you want to enter");
                            int val = Convert.ToInt32(Console.ReadLine());
                            m1.Push(val);
                            break;
                        }
                    case 2:
                        {
                            m1.Pop();
                            break;
                        }

                    case 3:
                        {
                            m1.display();
                            break;
                        }
                    case 4:
                        {
                            MyStack newStack = m1.Clone() as MyStack;
                            newStack.display();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid input");
                            break;
                        }
                }

            } while (i != 5);
        }
    }
}
