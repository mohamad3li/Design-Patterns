using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilty
{
    class Divider : Calculator
    {
        private Calculator next;
        public void Operation(char op, double first, double second)
        {
            if (op == '/')
            {
                Console.WriteLine($"{first} / {second} = {first / second}");
            }
            else
            {
                next.Operation(op, first, second);
            }
        }

        public void SetNext(Calculator next)
        {
            this.next = next;
        }
    }
}
