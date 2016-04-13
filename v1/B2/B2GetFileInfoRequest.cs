using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_get_file_info", Method = WebRequestMethods.Http.Post)]
    public class B2GetFileInfoRequest
        : B2Request<B2GetFileInfoResponse>
    {
        [RestContent("content")]
        public B2FileInfoRequestContent Content { get; set; }   
 
        private B2GetFileInfoRequest() : base() { }
    }
}
