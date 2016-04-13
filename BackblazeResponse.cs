using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST;

namespace Common.Net.REST.Backblaze
{
    public abstract class BackblazeResponse
        : RestResponse
    {
        internal protected BackblazeResponse() : base() { }
    }
}
