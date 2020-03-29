using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Request : IRequest
    {
        public string CallAPI(string url)
        {
            Console.WriteLine("In real request");
            return $"Result of calling {url} from Real Request at {DateTime.Now}";
        }
    }
}
