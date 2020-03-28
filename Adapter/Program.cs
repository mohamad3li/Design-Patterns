using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ITarget target = new Adapter(new Adaptee());
            target.Request();
            Console.ReadKey();
        }
    }
}
