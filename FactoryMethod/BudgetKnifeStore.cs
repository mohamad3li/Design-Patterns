using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class BudgetKnifeStore : KnifeStore
    {
        
        public override IKnife CreateKnife(string knifeType)
        {
            if (knifeType=="chefs")
            {
                return new BudgetChefsKnife();
            }
            else if (knifeType=="steak")
            {
                return new BudgetSteakKnife();
            }
        }
    }
}
