using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Single
    {
        private static Single uniqueSingle = null;
        public int MyProperty { get; set; }
        private Single()
        {

        }
        public static Single getInstance()
        {
            if (uniqueSingle ==null)
            {
                uniqueSingle = new Single();
             }
            return uniqueSingle;
        }
    }
}
