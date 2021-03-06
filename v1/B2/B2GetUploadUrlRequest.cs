﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Content;

    [RestRequest("b2api/v1/b2_get_upload_url", Method = WebRequestMethods.Http.Post)]
    public class B2GetUploadUrlRequest
        : B2Request<B2GetUploadUrlResponse>
    {
        [RestContent("content")]
        public B2GetUploadUrlRequestContent Content { get; set; }

        private B2GetUploadUrlRequest() : base() { }
    }
}
