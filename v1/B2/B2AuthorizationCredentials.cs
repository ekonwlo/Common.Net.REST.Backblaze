using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Common.Net.REST.Backblaze.v1.B2
{
    public class B2AuthorizationCredentials
        : ICredentials
    {
        public string AccountId {get; private set; }

        public string ApplicationKey { get; private set; }

        public B2AuthorizationCredentials(string accountId, string applicationKey)
        {
            this.AccountId = accountId;
            this.ApplicationKey = applicationKey;
        }

        public NetworkCredential GetCredential(Uri uri, string authType)
        {
            throw new NotImplementedException();
        }
    }
}
