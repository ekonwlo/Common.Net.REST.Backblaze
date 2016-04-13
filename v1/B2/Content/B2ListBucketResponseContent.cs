using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2ListBucketResponseContent
    {
        [RestContent("buckets")]
        public B2BucketInfo[] Buckets { get; internal set; }

        internal B2ListBucketResponseContent() { }
    }
}
