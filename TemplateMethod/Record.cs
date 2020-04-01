using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class Record
    {
        public void Save()
        {
            Validate();
            Console.WriteLine("Saving to DB");
            AfterSave();
        }
        protected abstract void Validate();
        protected abstract void AfterSave();

    }
}
