using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;
    
    public class B2DeleteFileVersionResponse
        : B2Response
    {
        [RestContent("content")]
        public B2DeleteFileVersionResponseContent Content { get; internal set; }

        private B2DeleteFileVersionResponse() : base() { }
    }
}
