using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    public class B2GetFileInfoResponse
        : B2Response
    {
        [RestContent("content")]
        public B2FileInfoResponseContent Content { get; internal set; }

        private B2GetFileInfoResponse() : base() { }
    }
}
