using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment3_Q1
{
    class MarketingExecutive:Employee
    {
        private double KilometerTravel;
        private double TourAllowance;
        private double TelephoneAllowance;
        private double Marketing_gross;
        private double pf;
        private double netsalary;
        private double tds;

        public MarketingExecutive(int empno, string empname, double _salary, double kilometertravel)
        {
            this.EMPNO = empno;
            this.EMPNAME = empname;
            this.SALARY = _salary;
            this.KilometerTravel = kilometertravel;
            this.GROSSSALARY = GROSSSALARY;
            this.TOURALLOWANCE = TourAllowance;
            this.TELEPHONEALLOWANCE = TelephoneAllowance;
            this.MARKETING_GROSS = Marketing_gross;
        }

        public double KILOMETERTRAVEL
        {
            set
            {
                this.KilometerTravel = value;
            }
            get
            {
                return this.KilometerTravel;
            }
        }
        public double TOURALLOWANCE
        {
            set
            {
                this.TourAllowance = 5 * KILOMETERTRAVEL;
            }
            get
            {
                return this.TourAllowance;
            }
        }
        public double TELEPHONEALLOWANCE
        {
            set
            {
                this.TelephoneAllowance = 1000;
            }
            get
            {
                return this.TelephoneAllowance;
            }
        }
        public double MARKETING_GROSS
        {
            set
            {
                this.Marketing_gross = GROSSSALARY + TELEPHONEALLOWANCE + TOURALLOWANCE + KILOMETERTRAVEL;
            }
            get
            {
                return this.Marketing_gross;
            }
        }

        public void CalculateSalary()
        {
            pf = (10 * MARKETING_GROSS) / 100;
            tds = (18 * MARKETING_GROSS) / 100;
            netsalary = MARKETING_GROSS - (pf + tds);
            //Console.WriteLine("Marketing_gross is {0}", MARKETING_GROSS);
            //Console.WriteLine("Netsalary of Marketing is {0}", netsalary);
        }

        public void printdetails()
        {
            Console.WriteLine("empno is {0}", EMPNO);
            Console.WriteLine("name is {0}", EMPNAME);
            Console.WriteLine("salary is {0}", SALARY);
            Console.WriteLine("manager grosssalary is {0}", MARKETING_GROSS);
            Console.WriteLine("manager netsalary is {0}", netsalary);
        }

    }
}
