using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;

    [RestException(typeof(B2Exception))]
    [RestContentType("application/json", "charset=utf-8")]
    public abstract class B2Request<T>
        : BackblazeRequest<T> where T : BackblazeResponse
    {
        private string _accountAuthorizationToken;

        [RestHeader("Authorization")]
        public string AccountAuthorizationToken
        {
            get { return _accountAuthorizationToken; }
            set { _accountAuthorizationToken = value; }
        }

        protected internal B2Request() { }
    }
}
