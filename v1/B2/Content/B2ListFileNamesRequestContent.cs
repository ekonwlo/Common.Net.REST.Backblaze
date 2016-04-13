using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2ListFileNamesRequestContent
    {
        [RestContent("bucketId")]
        public string BucketId { get; internal set; }

        [RestContent("startFileName", Mandatory = false)]
        public string StartFileName { get; internal set; }

        [RestContent("maxFileCount", Mandatory = false)]
        public int MaxFileCount { get; internal set; }

        public B2ListFileNamesRequestContent(string bucketId, int @maxFileCount = 100)
        {
            BucketId = bucketId;
            MaxFileCount = @maxFileCount;
        }

        public B2ListFileNamesRequestContent(string bucketId, string startFileName, int @maxFileCount = 100)
        {
            BucketId = bucketId;
            StartFileName = startFileName;
            MaxFileCount = @maxFileCount;
        }

    }
}
