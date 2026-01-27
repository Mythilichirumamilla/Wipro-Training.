using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public class savingsaccount : BankAccount
    {
        public savingsaccount(string accNumber, string pin, decimal interest, string branchCode)
            : base(accNumber, pin, interest, branchCode)
        {
        }
        // Method to calculate interest for saving account
        public decimal CalculateInterest()
        {
            return balance * interestRate / 100;
        }
    }
}
