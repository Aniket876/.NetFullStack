using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment2
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double hra;
        private double ta;
        private double da;
        private double pf;
        private double tds;
        private double NetSalary;
        private double GrossSalary;

        public int EMPNO
        {
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("invalid employee id");
                    }
                    this.EmpNo = value;
                }
                catch
                {
                    Console.WriteLine("invalid employee id");
                    Environment.Exit(1);
                }
            }
            get
            {
                return this.EmpNo;
            }
        }
        public string EMPNAME
        {
            set
            {
                try
                {
                    Exception e = new Exception("name cannot be null or empty");
                    if (string.IsNullOrEmpty(value))
                    {
                        throw e;
                    }
                    this.EmpName = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get
            {
                return this.EmpName;
            }
        }
        public double SALARY
        {
            set
            {
                try
                {
                    Exception e = new Exception("salary cannot be negative");
                    if (value < 0)
                    {
                        throw e;
                    }
                    this.Salary = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get
            {
                return this.Salary;
            }
        }
        public Employee()
        {
            //employee default constructor.
        }
        public Employee(int empno, string empname, double _salary)
        {
            this.EMPNO = empno;
            this.EMPNAME = empname;
            this.SALARY = _salary;
            this.GROSSSALARY = GrossSalary;
        }

        public double GROSSSALARY
        {
            set
            {
                if (SALARY < 5000)
                {
                    hra = (10 * SALARY) / 100;
                    ta = (5 * SALARY) / 100;
                    da = (15 * SALARY) / 100;
                    GrossSalary = hra + ta + da + SALARY;
                }
                else if(SALARY<10000 && SALARY>5000)
                {
                    hra = (15 * SALARY) / 100;
                    ta = (10 * SALARY) / 100;
                    da = (20 * SALARY) / 100;
                    GrossSalary = hra + ta + da + SALARY;
                }
                else if(SALARY<15000 && SALARY > 10000)
                {
                    hra = (20 * SALARY) / 100;
                    ta = (15 * SALARY) / 100;
                    da = (25 * SALARY) / 100;
                    GrossSalary = hra + ta + da + SALARY;
                }
                else if(SALARY < 20000 && SALARY > 15000)
                {
                    hra = (25 * SALARY) / 100;
                    ta = (20 * SALARY) / 100;
                    da = (30 * SALARY) / 100;
                    GrossSalary = hra + ta + da + SALARY;
                }
                else if(SALARY>= 20000)
                {
                    hra = (30 * SALARY) / 100;
                    ta = (25 * SALARY) / 100;
                    da = (35 * SALARY) / 100;
                    GrossSalary = hra + ta + da + SALARY;
                }
            }
            get
            {
                return GrossSalary;
            }
        }
        public void CalculateSalary()
        {
                pf = (10 * GROSSSALARY) / 100;
                tds = (18 * GROSSSALARY) / 100;
                NetSalary = GROSSSALARY - (pf + tds);
        }

        public void printdetails()
        {
            Console.WriteLine("empno is {0}", EMPNO);
            Console.WriteLine("name is {0}", EMPNAME);
            Console.WriteLine("salary is {0}", SALARY);
            Console.WriteLine("grosssalary is {0}", GrossSalary);
            Console.WriteLine("netsalary is {0}", NetSalary);
        }
    }
}
