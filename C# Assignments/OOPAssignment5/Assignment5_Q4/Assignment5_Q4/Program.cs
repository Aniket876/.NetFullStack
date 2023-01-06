using System;

namespace Assignment5_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> st = new MyStack<int>();
            st.push(1);
            st.push(2);
            st.push(3);
            st.push(4);
            st.pop();
            st.display();


        }
    }
}
