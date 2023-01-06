using System;
using System.Collections.Generic;

namespace Assignment5_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double salary;
            string SearchName;
            Console.WriteLine("enter the count");
            int n = Convert.ToInt32(Console.ReadLine());
            List < Employee > arr = new List<Employee>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the id");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name");
                name = Console.ReadLine();
                Console.WriteLine("enter the salary");
                salary = Convert.ToDouble(Console.ReadLine());
                arr.Add(new Employee(id, name, salary));

            }
            Console.WriteLine("displaying the details");
            foreach(Employee emp in arr)
            {
                Console.WriteLine(emp);
            }
            Console.Write("the total number of elements in the list are ");
            Console.Write(arr.Count);
            Console.WriteLine("");
            Console.WriteLine("enter the name of the employee you want to search");
            SearchName = Console.ReadLine();
            bool found = false;
            foreach(Employee emp in arr)
            {
                if (emp.NAME.Equals(SearchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
            if (found)
            {
                Console.WriteLine("the data is present");
            }
            else
            {
                Console.WriteLine("no match found");
            }
        }
    }
}
