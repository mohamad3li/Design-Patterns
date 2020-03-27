using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class BankService
    {
        private Dictionary<int, IAccount> bankAccounts;
        public BankService()
        {
            bankAccounts = new Dictionary<int, IAccount>();
        }
        public int CreateNewAccount(int accountNumber,string type, Decimal initAmount)
        {
            IAccount newAccount = null;
            if (type=="saving")
            {
                newAccount = new Saving(accountNumber,initAmount);
            }
            else if (type=="chequing")
            {
                newAccount = new Chequing(accountNumber,initAmount);
            }
            else if(type=="investment")
            {
                newAccount = new Investment(accountNumber,initAmount);
            }
            if (newAccount!=null)
            {
                bankAccounts.Add(newAccount.getAccountNumber(), newAccount);
                return newAccount.getAccountNumber();
            }
            return -1;
        }
        public void TransferMoney(int from, int to, Decimal amount)
        {
            IAccount fromAccount = bankAccounts[from];
            IAccount toAccount = bankAccounts[to];
            fromAccount.transfer(toAccount, amount);
        }
        public Decimal GetAccountAmount(int accountNumber)
        {
           return bankAccounts[accountNumber].getAmount();
        }
    }
}
