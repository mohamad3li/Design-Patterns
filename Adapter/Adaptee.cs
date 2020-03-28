using System;

namespace Adapter
{
    internal class Adaptee
    {
        internal void SpecificRequest()
        {
            Console.WriteLine("Request processing ...");
        }
    }
}