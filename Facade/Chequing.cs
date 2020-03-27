using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Chequing : IAccount
    {
        private decimal amount;
        private int accountNumber;

        public Chequing(int accountNumber,decimal initAmount)
        {
            this.amount = initAmount;
            this.accountNumber = accountNumber;
        }

        public void Add(decimal amount)
        {
            this.amount += amount;
        }

        public int getAccountNumber()
        {
            return accountNumber;
        }

        public void transfer(IAccount toAccount, decimal amount)
        {
            this.amount -= amount;
            toAccount.Add(amount);
        }
        public Decimal getAmount()
        {
            return amount;
        }
    }
}
