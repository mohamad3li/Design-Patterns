using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class KnifeStore
    {
        public IKnife OrderKnife(String knifeType)
        {
            IKnife knife = CreateKnife(knifeType);
            return knife;
        }

       public abstract IKnife CreateKnife(String knifeType);
    }
}
