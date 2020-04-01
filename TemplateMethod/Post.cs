using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Post : Record
    {
        protected override void AfterSave()
        {
            Console.WriteLine("Publishing Post");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validating Post Content");
        }
    }
}
