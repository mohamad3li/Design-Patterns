using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IState
    {
        void InsertDollar(VendingMachine vendingMachine);
        void EjectMoney(VendingMachine vendingMachine);
        void Dispense(VendingMachine vendingMachine);
    }
}
