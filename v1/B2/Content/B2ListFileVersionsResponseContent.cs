using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2ListFileVersionsResponseContent
        : B2ListFileNamesResponseContent
    {
        [RestContent("nextFileId")]
        public string NextFileId { get; internal set; }

        internal B2ListFileVersionsResponseContent() : base() { }
    }
}
