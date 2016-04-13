using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2HideFileResponseContent
    {
        [RestContent("fileId")]
        public string FileId { get; internal set; }

        [RestContent("fileName")]
        public string FileName { get; internal set; }

        [RestContent("action")]
        public string Action { get; internal set; }

        internal B2HideFileResponseContent() { }
    }
}
