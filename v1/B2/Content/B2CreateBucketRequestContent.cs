using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2CreateBucketRequestContent
    {
        [RestContent("accountId")]
        public string AccountId { get; private set; }

        [RestContent("bucketName")]
        public string BucketName { get; private set; }

        [RestContent("bucketType")]
        public string BucketType { get; private set; }

        public B2CreateBucketRequestContent(string accountId, string bucketName, string @bucketType = "allPrivate")
        {
            this.AccountId = accountId;
            this.BucketName = bucketName;
            this.BucketType = bucketType;
        }
    }
}
