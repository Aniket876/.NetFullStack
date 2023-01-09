using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment3_Q1
{
    [Serializable]
    class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double Manager_gross;
        private double Manager_NetSalary;
        private double pf;
        private double tds;

        
        public double PETROLALLOWANCE
        {
            set
            {
                this.PetrolAllowance = (8 * SALARY) / 100;
            }
            get
            {
                return this.PetrolAllowance;
            }
        }
        public double FOODALLOWANCE
        {
            set
            {
                this.FoodAllowance = (13 * SALARY) / 100;
            }
            get
            {
                return this.FoodAllowance;
            }
        }
        public double OTHERALLOWANCE
        {
            set
            {
                this.OtherAllowance = (3 * SALARY) / 100;
            }
            get
            {
                return this.OtherAllowance;
            }
        }
        public double MANAGER_GROSS
        {
            set
            {
                this.Manager_gross = GROSSSALARY + OTHERALLOWANCE + FOODALLOWANCE + PETROLALLOWANCE;
            }
            get
            {
                return this.Manager_gross;
            }
        }
        public Manager(int empno, string empname, double _salary)
        {
            this.EMPNO = empno;
            this.EMPNAME = empname;
            this.SALARY = _salary;
            this.GROSSSALARY = GROSSSALARY;
            this.FOODALLOWANCE = FOODALLOWANCE;
            this.PETROLALLOWANCE = PETROLALLOWANCE;
            this.OTHERALLOWANCE = OTHERALLOWANCE;
            this.MANAGER_GROSS = MANAGER_GROSS;
        }
        public void CalculateSalary()
        {
            pf = (10 * MANAGER_GROSS) / 100;
            tds = (18 * MANAGER_GROSS) / 100;
            Manager_NetSalary = MANAGER_GROSS - (pf + tds);
            //Console.WriteLine("Manager_gross is {0}", MANAGER_GROSS);
            //Console.WriteLine("Netsalary of Manager is {0}", Manager_NetSalary);
        }
        public void printdetails()
        {
            Console.WriteLine("empno is {0}", EMPNO);
            Console.WriteLine("name is {0}", EMPNAME);
            Console.WriteLine("salary is {0}", SALARY);
            Console.WriteLine("manager grosssalary is {0}", MANAGER_GROSS);
            Console.WriteLine("manager netsalary is {0}", Manager_NetSalary);
        }
        
    }
}
