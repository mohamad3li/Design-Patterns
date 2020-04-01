using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class User : Record
    {
        protected override void AfterSave()
        {
            Console.WriteLine("Notify User");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validating User");
        }
    }
}
