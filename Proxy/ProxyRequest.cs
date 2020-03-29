using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ProxyRequest : IRequest
    {
        private Request realRequest;
        private Dictionary<String, String> results;
        public ProxyRequest()
        {
            this.results = new Dictionary<string, string>();
            this.realRequest = new Request();
        }
        public string CallAPI(string url)
        {
            Console.WriteLine("In proxy request");
            if (!results.ContainsKey(url))
            
            {
                results[url] = realRequest.CallAPI(url);
            }
            return results[url];
        }
    }
}
