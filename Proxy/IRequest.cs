using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IRequest
    {
        String CallAPI(String url);
    }
}
