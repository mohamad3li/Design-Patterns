using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine(3);
            vendingMachine.DoReleaseProduct();
            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            Console.ReadKey();
        }
    }
}
