using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class WebPageDecorator : WebPage
    {
        protected WebPage page;
        public WebPageDecorator(WebPage page)
        {
            this.page = page;
        }
        public virtual void Display()
        {
            this.page.Display();
        }
    }
}
