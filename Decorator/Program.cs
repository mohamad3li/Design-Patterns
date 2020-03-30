using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPage page = new BasicWebPage();
            page = new AuthenticatedWebPage(page);
            page = new AuthorizedWebPage(page);
            page.Display();
            Console.ReadKey();

        }
    }
}
