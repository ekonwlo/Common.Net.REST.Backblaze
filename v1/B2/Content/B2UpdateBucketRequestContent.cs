using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2UpdateBucketRequestContent
    {
        [RestContent("accountId")]
        public string AccountId { get; private set; }

        [RestContent("bucketId")]
        public string BucketId { get; private set; }

        [RestContent("bucketType")]
        public string BucketType { get; private set; }

        public B2UpdateBucketRequestContent(string accountId, string bucketId, string @bucketType = "allPrivate")
        {
            AccountId = accountId;
            BucketId = bucketId;
            BucketType = bucketType;
        }
    }
}
