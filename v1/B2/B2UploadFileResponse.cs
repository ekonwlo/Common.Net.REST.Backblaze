using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    public class B2UploadFileResponse
        : BackblazeResponse
    {
        [RestContent("content")]
        public B2UploadFileResponseContent Content { get; internal set; }

        private B2UploadFileResponse() : base() { }
    }
}
