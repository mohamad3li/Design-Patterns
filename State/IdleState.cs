using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IdleState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Payment required");
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("No money to return");
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("One dollar inserted");
            vendingMachine.SetState(new HasOneDollarState());
        }
    }
}
