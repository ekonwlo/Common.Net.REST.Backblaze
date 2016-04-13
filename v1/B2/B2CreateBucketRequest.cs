using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_create_bucket", Method = WebRequestMethods.Http.Post)]
    public class B2CreateBucketRequest
        : B2Request<B2CreateBucketResponse>
    {
        [RestContent("content")]
        public B2CreateBucketRequestContent Content { get; set; }

        private B2CreateBucketRequest() : base() { }
    }
}
