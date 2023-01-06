using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_Q4
{
    class MyStack<T>
    {
        private T[] arr = new T[20];
        private int top = -1;
        private int size;
        public int SIZE
        {
            set
            {
                this.size = arr.Length;
            }
            get
            {
                return this.size;
            }
        }
        public MyStack()
        {
            this.SIZE = SIZE;
        }
        public void push(T element)
        {
            try
            {
                if (top >= SIZE - 1)
                {
                    throw new Exception("stack is full");

                }
                arr[++top] = element;
                Console.WriteLine("element pushed into stack");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("stack is empty");
                }
                Console.WriteLine("element poped {0}", arr[top]);
                Array.Clear(arr, top--, 1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void display()
        {
            Console.WriteLine("elements of array are ");
            for(int i = 0; i <= top; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
