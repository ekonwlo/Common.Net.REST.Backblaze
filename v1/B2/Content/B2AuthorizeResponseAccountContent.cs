using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2AuthorizeResponseAccountContent
    {
        [RestContent("accountId")]
        public string AccountId { get; internal set; }

        [RestContent("authorizationToken")]
        public string AuthorizationToken { get; internal set; }

        [RestContent("apiUrl")]
        public string ApiUrl { get; internal set; }

        [RestContent("downloadUrl")]
        public string DownloadUrl { get; internal set; }

        [RestContent("minimumPartSize")]
        public int MinimumPartSize { get; internal set; }
    
        internal B2AuthorizeResponseAccountContent() { }
    }
}
