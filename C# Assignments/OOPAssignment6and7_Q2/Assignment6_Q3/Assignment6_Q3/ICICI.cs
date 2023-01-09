using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_Q3
{
    class ICICI:Account
    {
        public ICICI() : base()
        {

        }
        public bool UnderBalance(double amount)
        {
            return false;
        }
        public bool BalanceZero(double amount)
        {
            if (BALANCE <= 0||BALANCE-amount <= 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is/will be insufficient/zero in Account");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
