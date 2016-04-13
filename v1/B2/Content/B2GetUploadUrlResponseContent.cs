using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2GetUploadUrlResponseContent
    {
        //The unique ID of the bucket.
        [RestContent("bucketId")]
        public string BucketId { get; internal set; }

        //The URL that can be used to upload files to this bucket, see b2_upload_file.
        [RestContent("uploadUrl")]
        public string UploadUrl { get; internal set; }
    
        //The authorizationToken that must be used when uploading files to this bucket. This token is valid for 24 hours or until the uploadUrl endpoint rejects an upload, see b2_upload_file 
        [RestContent("authorizationToken")]
        public string AuthorizationToken { get; internal set; }
	
        internal B2GetUploadUrlResponseContent() { }
    }
}
