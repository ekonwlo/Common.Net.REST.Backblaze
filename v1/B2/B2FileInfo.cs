using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;

    public class B2FileInfo
    {
        //The unique identifier for this version of this file. Used with b2_get_file_info, b2_download_file_by_id, and b2_delete_file_version.
        [RestContent("fileId")]
        public string FileId { get; internal set; }

        //The name of this file, which can be used with b2_download_file_by_name.
        [RestContent("fileName")]
        public string FileName { get; internal set; }

        //The MIME type of the file.
        [RestContent("contentType")]
        public string ContentType { get; internal set; }
	    
        //The SHA1 of the data that you provided when uploading the file.
        [RestContent("contentSha1")]
        public string ContentSha1 { get; internal set; }

        //A JSON object with the file info you supplied when uploading the file. Example:

        //{
        //    "src_last_modified_millis": "1456275056"
        //}
        //[RestContent("fileInfo")]
        //public string FileInfo { get; internal set; }

        //Always "upload".
        [RestContent("action")]
        public string Action { get; internal set; }
	
        //The number of bytes stored in the file.
        [RestContent("size")]
        public long Size { get; internal set; }

        //This is a UTC time when this file was uploaded. It is a base 10 number of milliseconds since midnight, January 1, 1970 UTC. This fits in a 64 bit integer such as the type "long" in the programming language Java. It is intended to be compatible with Java's time long. For example, it can be passed directly into the java call Date.setTime(long time). 
        [RestContent("uploadTimestamp")]
        public long UploadTimestamp { get; internal set; }

        private B2FileInfo() { }
    }
}
