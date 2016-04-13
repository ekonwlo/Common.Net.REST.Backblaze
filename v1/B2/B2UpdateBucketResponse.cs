using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    
    public class B2UpdateBucketResponse
        : B2Response
    {
        [RestContent("content")]
        public B2BucketInfo BucketInfo { get; internal set; }

        private B2UpdateBucketResponse() : base() { }
    }
}
