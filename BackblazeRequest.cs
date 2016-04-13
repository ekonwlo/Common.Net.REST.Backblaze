using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze
{
    using Attributes;

    public abstract class BackblazeRequest<T>
        : RestRequest<T> where T : BackblazeResponse
    {
         protected internal BackblazeRequest() { }
    }
}
