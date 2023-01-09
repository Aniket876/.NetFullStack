using System;

namespace OOPAssignment3_Q1
{
    [Serializable]
    class Program
    {
        delegate void Managerdetails();
        static void Main(string[] args)
        {
            int empid;
            string empname;
            double salary;
            double kilometertravel;
            Console.WriteLine("enter the id: ");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            empname = Console.ReadLine();
            Console.WriteLine("enter the salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the kilometer's travel for Marketing Executive");
            kilometertravel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee details: ");
            Employee e = new Employee(empid, empname, salary);
            e.CalculateSalary();
            e.printdetails();
            Console.WriteLine("Manager details: \n");
            Manager m = new Manager(empid, empname, salary);
            Managerdetails details = new Managerdetails(m.printdetails);
            m.CalculateSalary();
            Console.WriteLine("MarketingExecutive details: \n");
            MarketingExecutive m1 = new MarketingExecutive(empid, empname, salary, kilometertravel);
            m1.CalculateSalary();
            details += m1.printdetails;
            details();
            Console.ReadKey();

        }
    }
}
