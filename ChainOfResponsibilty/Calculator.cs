using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilty
{
    interface Calculator
    {
        void Operation(char op, double first, double second);
        void SetNext(Calculator next);
    }
}
