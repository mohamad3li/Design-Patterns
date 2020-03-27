using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Single s = Single.getInstance();
            Console.WriteLine(s.MyProperty);
            s.MyProperty = 10;
            Console.WriteLine(s.MyProperty);
            Single s2 = Single.getInstance();
            Console.WriteLine(s2.MyProperty);
            Console.ReadKey();
        }
    }
}
