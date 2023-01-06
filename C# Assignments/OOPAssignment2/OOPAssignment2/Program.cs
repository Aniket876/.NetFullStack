using System;

namespace OOPAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int empid;
            string empname;
            double salary;
            Console.WriteLine("enter the id: ");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            empname = Console.ReadLine();
            Console.WriteLine("enter the salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Employee emp = new Employee(empid,empname,salary);
            emp.CalculateSalary();
            emp.printdetails();
            Console.ReadKey();

        }
    }
}
