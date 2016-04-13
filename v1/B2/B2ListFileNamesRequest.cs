using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    //[RestRequest("v1/b2_list_buckets", Method = WebRequestMethods.Http.Post)]
    [RestRequest("b2api/v1/b2_list_file_names", Method = WebRequestMethods.Http.Post)]
    public class B2ListFileNamesRequest
         : B2Request<B2ListFileNamesResponse>
    {
        [RestContent("content")]
        public B2ListFileNamesRequestContent Content { get; set; }

        private B2ListFileNamesRequest() : base() { }
    }
}
