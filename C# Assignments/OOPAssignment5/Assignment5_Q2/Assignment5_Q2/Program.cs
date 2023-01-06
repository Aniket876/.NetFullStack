using System;
using System.Collections;

namespace Assignment5_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double salary;
            Console.WriteLine("enter the count of employees you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayList EmployeeList = new ArrayList();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("enter id");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name");
                name = Console.ReadLine();
                Console.WriteLine("enter the salary");
                salary = Convert.ToDouble(Console.ReadLine());
                EmployeeList.Add(new Employee(id, name, salary));

            }
            Console.WriteLine("displaying employee details");
            foreach(Employee emp in EmployeeList)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
