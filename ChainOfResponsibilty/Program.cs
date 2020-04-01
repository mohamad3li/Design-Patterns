using System;

namespace ChainOfResponsibilty
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator adder = new Adder();
            Calculator sub = new Subtractor();
            Calculator mul = new Multiplier();
            Calculator div = new Divider();
            adder.SetNext(sub);
            sub.SetNext(mul);
            mul.SetNext(div);
            adder.Operation('*',10,5);
            Console.ReadKey();
        }
    }
}
