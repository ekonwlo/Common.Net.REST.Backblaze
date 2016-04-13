using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Transformation;

    //[RestContentType("application/json", "charset=utf-8")]
    [RestException(typeof(B2Exception))]
    [RestRequest(Method = WebRequestMethods.Http.Post)]
    public class B2UploadFileRequest
        : BackblazeRequest<B2UploadFileResponse>
    {
        [RestHeader("Authorization")]
        public string UploadAuthorization { get; set; }

        //The name of the file, in percent-encoded UTF-8. For example, spaces should be replaced with %20. For more information, see Files for requirements on file names and String Encoding for how to encode strings. 
        [RestHeader("X-Bz-File-Name")]
        [PropertyTransformation(typeof(FileNameTransformation))]
        public string FileName { get; set; }

        [RestHeader("X-Bz-Content-Sha1")]
        [PropertyTransformation(typeof(Sha1Transformation))]
        public byte[] ContentSha1 { get; set; }
        
        private B2UploadFileRequest() : base() { }
    }
}
