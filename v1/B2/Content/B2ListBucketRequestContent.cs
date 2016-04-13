using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2ListBucketRequestContent
    {
        [RestContent("accountId")]
        public string AccountId { get; internal set; }

        public B2ListBucketRequestContent(string accountId)
        {
            AccountId = accountId;
        }
    }
}
