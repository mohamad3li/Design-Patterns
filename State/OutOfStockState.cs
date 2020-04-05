namespace State
{
    class OutOfStockState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            System.Console.WriteLine("Sorry out of Stock");
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            
        }
    }
}