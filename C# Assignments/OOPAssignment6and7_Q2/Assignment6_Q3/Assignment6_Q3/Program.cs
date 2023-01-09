using System;
using System.IO;

namespace Assignment6_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI cust = new ICICI();
            cust.acceptdetails("ICICI Bank");
            cust.Deposit(15000);
            cust.Withdraw(10000, cust.UnderBalance, cust.BalanceZero);
            cust.Deposit(5000);

            HdfcBank hd_cust = new HdfcBank();
            hd_cust.acceptdetails("Hdfc Bank");
            hd_cust.Deposit(14000);
            hd_cust.Withdraw(3000, hd_cust.UnderBalance, hd_cust.BalanceZero);
            hd_cust.Deposit(10000);

            StreamReader s = new StreamReader(@"C:\Users\ADHANAIT\.netassignments\.NetFullStack\C# Assignments\output.txt");
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();

        }
    }
}
