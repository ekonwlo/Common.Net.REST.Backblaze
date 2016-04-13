using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2DeleteBucketRequestContent
    {
        [RestContent("accountId")]
        public string AccountId { get; private set; }

        [RestContent("bucketId")]
        public string BucketId { get; private set; }

        public B2DeleteBucketRequestContent(string accountId, string bucketId)
        {
            this.AccountId = accountId;
            this.BucketId = bucketId;   
        }
    }
}
