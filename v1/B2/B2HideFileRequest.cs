using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_hide_file", Method = WebRequestMethods.Http.Post)]
    public class B2HideFileRequest
        : B2Request<B2HideFileResponse>
    {
        [RestContent("content")]
        public B2HideFileRequestContent Content { get; set; }

        private B2HideFileRequest() : base() { }
    }
}
