using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2FileInfoResponseContent
    {
        [RestContent("accountId")]
        public string AccountId { get; internal set; }

        [RestContent("bucketId")]
        public string BucketId { get; internal set; }

        [RestContent("contentLength")]
        public int ContentLength { get; internal set; }

        [RestContent("contentSha1")]
        public string ContentSha1 { get; internal set; }

        [RestContent("contentType")]
        public string ContentType { get; internal set; }

        [RestContent("fileId")]
        public string FileId { get; internal set; }

        [RestContent("fileName")]
        public string FileName { get; internal set; }
        
        internal B2FileInfoResponseContent() { }
    }
}
