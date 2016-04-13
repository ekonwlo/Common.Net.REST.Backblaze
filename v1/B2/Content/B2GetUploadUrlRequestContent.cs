using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2GetUploadUrlRequestContent
    {
        //The ID of the bucket that you want to upload to.
        [RestContent("bucketId")]
        public string BucketId { get; private set; }

        public B2GetUploadUrlRequestContent(string bucketId) 
        {
            this.BucketId = bucketId;
        }
    }
}
