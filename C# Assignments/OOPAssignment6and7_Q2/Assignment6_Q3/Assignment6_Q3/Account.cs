using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment6_Q3
{
    public delegate bool UnderBalance(double amount);
    public delegate bool BalanceZero(double amount);
    class Account: User
    {
        private int AccountNumber;
        private string CustomerName;
        private double Balance;

        public void acceptdetails(string bank_name)
        {
            StreamWriter s = new StreamWriter(@"C:\Users\ADHANAIT\.netassignments\.NetFullStack\C# Assignments\output.txt", append:true);
            s.WriteLine("Bank Name: {0}",bank_name);
            Console.WriteLine("enter account number of the user");
            ACCOUNTNUMBER = Convert.ToInt32(Console.ReadLine());
            s.WriteLine("Account number: {0}", ACCOUNTNUMBER);
            Console.WriteLine("enter the customer name");
            CUSTOMERNAME = Console.ReadLine();
            s.WriteLine("CustomerName: {0}", CUSTOMERNAME);
            Console.WriteLine("enter the balance");
            BALANCE = Convert.ToDouble(Console.ReadLine());
            s.WriteLine("Balance: {0}", BALANCE);
            Console.WriteLine("The account has been created");
            s.Close();
        }
        public Account(int AccountNumber,string CustomerName,double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.CustomerName = CustomerName;
            this.Balance = Balance;
        }
        public Account() { }
        public int ACCOUNTNUMBER
        {
            set
            {
                this.AccountNumber = value;
            }
            get
            {
                return this.AccountNumber;
            }
        }
        public string CUSTOMERNAME
        {
            set
            {
                this.CustomerName = value;
            }
            get
            {
                return this.CustomerName;
            }
        }
        public double BALANCE
        {
            set
            {
                this.Balance = value;
            }
            get
            {
                return this.Balance;
            }
        }
        public void Withdraw(double amt,UnderBalance UB,BalanceZero ZB)
        {   
            if (!UB(amt) && !ZB(amt))
            {
                StreamWriter s = new StreamWriter(@"C:\Users\ADHANAIT\.netassignments\.NetFullStack\C# Assignments\output.txt", append: true);
                BALANCE -= amt;
                Console.WriteLine("Amount withdrawn, Current Balance is {0}", BALANCE);
                s.WriteLine("new amount: {0}", BALANCE);
                s.Close();
            }
        }
        public void Deposit(double amt)
        {
            StreamWriter s = new StreamWriter(@"C:\Users\ADHANAIT\.netassignments\.NetFullStack\C# Assignments\output.txt", append: true);
            BALANCE += amt;
            Console.WriteLine("Amount Credited, New Balance is {0}", BALANCE);
            s.WriteLine("Balance credited {0}", BALANCE);
            s.Close();
            
        }
    }
}
