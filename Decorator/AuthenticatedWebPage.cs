using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class AuthenticatedWebPage : WebPageDecorator
    {
        public AuthenticatedWebPage(WebPage page) : base(page)
        {
        }

        public override void Display()
        {
            page.Display();
            Console.WriteLine("Authenticated User");
        }
    }
}
