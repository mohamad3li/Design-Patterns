using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class AuthorizedWebPage : WebPageDecorator
    {
        public AuthorizedWebPage(WebPage page) : base(page)
        {
        }

        public override void Display()
        {
            page.Display();
            Console.WriteLine("Authorized User");
        }
    }
}
