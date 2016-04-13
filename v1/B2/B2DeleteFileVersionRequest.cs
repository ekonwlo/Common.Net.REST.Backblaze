using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_delete_file_version", Method = WebRequestMethods.Http.Post)]
    public class B2DeleteFileVersionRequest
        : B2Request<B2DeleteFileVersionResponse>
    {
        [RestContent("content")]
        public B2DeleteFileVersionRequestContent Content { get; set; }

        private B2DeleteFileVersionRequest() : base() { }
    }
}
