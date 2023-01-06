using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment3_Q2
{
    public class StackException : Exception
    {
        public StackException(string msg) : base(msg) { }
    }
    class MyStack:ICloneable
    {
        private int[] arr = new int[20];
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
        public object Clone()
        {
            Console.WriteLine("Cloned Array");
            MyStack newStack = new MyStack
            {
                arr = this.arr,
                top = this.top,
                size = this.size
            };
            return newStack;
        }
        public void Push(int val)
        {
            try
            {
                if(top == arr.Length - 1)
                {
                    throw new StackException("Stack is full");
                }
                arr[++top] = val;
                Console.WriteLine("Value entered {0}",val);
            }
            catch(StackException message)
            {
                Console.WriteLine(message);
            }
        }
        public void Pop()
        {
            try
            {
                if(top < 0)
                {
                    throw new StackException("Stack is Empty");
                }
                int value = arr[top];
                Console.WriteLine("value removed {0} from position {1}", value, top);
                top -= 1;
            }
            catch(StackException message)
            {
                Console.WriteLine(message);
            }
        }

        public void display()
        {
            for(int i = 0; i <= top; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine("");
            }
        }
    }
}
