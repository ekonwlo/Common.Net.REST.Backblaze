using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Common.Runtime.Serialization.Attributes;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
    using Transformation;

    //[RestRequest("b2api/v1/b2_authorize_account", Method = WebRequestMethods.Http.Post)]
    [RestContentType("application/json", "charset=utf-8")]
    [RestRequest("b2api/v1/b2_authorize_account")]
    public class B2AuthorizeAccountRequest
        : BackblazeRequest<B2AuthorizeAccountResponse>
    {
        [RestHeader("Authorization")]
        [PropertyTransformation(typeof(AuthorizationTransformation))]
        public B2AuthorizationCredentials Authorization { get; set; }

        private B2AuthorizeAccountRequest() : base() { }
    }
}
