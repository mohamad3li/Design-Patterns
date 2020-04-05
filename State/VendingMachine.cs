using System;

namespace State
{
    public class VendingMachine
    {
        private IState state;
        private int count;
        public VendingMachine(int count)
        {
            if (count>0)
            {
                this.count = count;
                state = new IdleState();
            }
            else
            {
                this.count = 0;
                state = new OutOfStockState();
            }
        }
        public void SetState(IState state)
        {
            this.state = state;
        }

        public void DoReturnMoney()
        {
            Console.WriteLine("return money");
        }

        public int GetCount()
        {
            return count;
        }

        public void DoReleaseProduct()
        {
            Console.WriteLine("release product");
            this.count--;
        }
        public void Dispense()
        {
            state.Dispense(this);
        }

        public void EjectMoney()
        {
            state.EjectMoney(this);
        }

        public void InsertDollar()
        {
            state.InsertDollar(this);
        }
    }
}