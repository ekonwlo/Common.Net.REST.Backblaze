using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Content;
    using Attributes;

    public class B2AuthorizeAccountResponse
        : BackblazeResponse
    {
        [RestContent("content")]
        public B2AuthorizeResponseAccountContent Content { get; internal set; }

        private B2AuthorizeAccountResponse() : base() { }
    }
}
