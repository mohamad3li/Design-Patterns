namespace State
{
     class HasOneDollarState:IState
    {
        public HasOneDollarState()
        {
        }

        public void Dispense(VendingMachine vendingMachine)
        {
            System.Console.WriteLine("releasing product");
            if (vendingMachine.GetCount()>1)
            {
                vendingMachine.DoReleaseProduct();
                vendingMachine.SetState(new IdleState());
            }
            else
            {
                vendingMachine.DoReleaseProduct();
                vendingMachine.SetState(new OutOfStockState());
            }
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            System.Console.WriteLine("Returning money");
            vendingMachine.DoReturnMoney();
            vendingMachine.SetState(new IdleState());
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            System.Console.WriteLine("already has one dollar");
            vendingMachine.DoReturnMoney();
            vendingMachine.SetState(new IdleState());
        }
    }
}