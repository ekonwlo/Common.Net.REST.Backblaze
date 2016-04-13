using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_update_bucket", Method = WebRequestMethods.Http.Post)]
    public class B2UpdateBucketRequest
        : B2Request<B2UpdateBucketResponse>
    {
        [RestContent("content")]
        public B2UpdateBucketRequestContent Content { get; set; }

        private B2UpdateBucketRequest() : base() { }
    }
}
