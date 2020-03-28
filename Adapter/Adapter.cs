using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : ITarget
    {
        private Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
