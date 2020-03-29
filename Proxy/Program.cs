using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyRequest proxyRequest = new ProxyRequest();
            proxyRequest.CallAPI("Google");
            proxyRequest.CallAPI("Google");
            proxyRequest.CallAPI("Google");
            Console.ReadKey();
        }
    }
}
