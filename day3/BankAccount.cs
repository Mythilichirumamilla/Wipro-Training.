using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public class BankAccount
    {
        private string accountPin;
        public string accountNumber;
        protected decimal interestRate;
        internal string bankbranchCode;
        protected decimal balance;
        public BankAccount(string accNumber,string pin , decimal interest,string branchCode)
        {
            accountPin = pin;
            accountNumber = accNumber;
            interestRate = interest;
            bankbranchCode = branchCode;
            
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
    }
}
