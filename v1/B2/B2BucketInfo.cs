using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;

    public class B2BucketInfo
    {
        [RestContent("accountId")] // The account that the bucket is in.
        public string AccountId { get; internal set; }

        [RestContent("bucketId")] // The unique ID of the bucket.
        public string BucketId { get; internal set; }

        [RestContent("bucketName")] // The unique name of the bucket.
        public string BucketName { get; internal set; }

        [RestContent("bucketType")] // Either "allPublic", meaning that files in this bucket can be downloaded by anybody, or "allPrivate", meaning that you need an authorization token to download the files. 
        public string BucketType { get; internal set; }

        internal B2BucketInfo() { }
    }
}
