using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    interface IAccount
    {
        int getAccountNumber();
        void transfer(IAccount toAccount, decimal amount);
        void Add(decimal amount);
        Decimal getAmount();
    }
}
