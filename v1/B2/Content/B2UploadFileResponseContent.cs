using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2UploadFileResponseContent
    {
        //The unique identifier for this version of this file. Used with b2_get_file_info, b2_download_file_by_id, and b2_delete_file_version.
        [RestContent("fileId")]
        public string FileId { get; internal set; }

        //The name of this file, which can be used with b2_download_file_by_name.
        [RestContent("fileName")]
        public string FileName { get; internal set; }

        //Your account ID.
        [RestContent("accountId")]
        public string AccountId { get; internal set; }

        //The bucket that the file is in.
        [RestContent("bucketId")]
        public string BucketId { get; internal set; }
	
        //The number of bytes stored in the file.
        [RestContent("contentLength")]
        public long ContentLength { get; internal set; }

        //The SHA1 of the bytes stored in the file.
        [RestContent("contentSha1")]
        public string ContentSha1 { get; internal set; }
	
        //The MIME type of the file.
        [RestContent("contentType")]
        public string ContentType { get; internal set; }

        ////The custom information that was uploaded with the file. This is a JSON object, holding the name/value pairs that were uploaded with the file.
        //[RestContent("fileInfo")]
        //public object FileInfo { get; internal set; }

        //Always "upload".
        [RestContent("action")]
        public string Action { get; internal set; }
	
        internal B2UploadFileResponseContent() { }
    }
}
