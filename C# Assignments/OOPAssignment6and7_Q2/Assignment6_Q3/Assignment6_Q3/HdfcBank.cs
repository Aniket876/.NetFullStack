using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_Q3
{
    class HdfcBank : Account
    {
        public HdfcBank():base(){}
        public bool BalanceZero(double amount) { return false; }
        public bool UnderBalance(double amount)
        {
            if (BALANCE < 1000 || BALANCE - amount < 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.1000");
                Console.WriteLine("Max amount that can be withdrawn: Rs {0}",BALANCE - 1000);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
