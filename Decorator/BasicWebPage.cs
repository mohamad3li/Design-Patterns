using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BasicWebPage : WebPage
    {
        public void Display()
        {
            Console.WriteLine("Basic web page");
        }
    }
}
