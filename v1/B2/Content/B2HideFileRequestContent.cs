using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2HideFileRequestContent
    {
        [RestContent("bucketId")]
        public string BucketId { get; internal set; }

        [RestContent("fileName")]
        public string FileName { get; internal set; }

        public B2HideFileRequestContent(string bucketId, string fileName)
        {
            BucketId = bucketId;
            FileName = fileName;
        }
    }
}
