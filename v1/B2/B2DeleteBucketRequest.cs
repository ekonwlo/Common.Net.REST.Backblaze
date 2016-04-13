using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_delete_bucket", Method = WebRequestMethods.Http.Post)]
    public class B2DeleteBucketRequest
        : B2Request<B2DeleteBucketResponse>
    {
        [RestContent("content")]
        public B2DeleteBucketRequestContent Content { get; set; }

        private B2DeleteBucketRequest() : base() { }
    }
}
