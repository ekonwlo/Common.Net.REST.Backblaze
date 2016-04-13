using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2ListFileNamesResponseContent
    {
        [RestContent("files")]
        public B2FileInfo[] Files { get; internal set; }

        [RestContent("nextFileName")]
        public string NextFileName { get; internal set; }

        internal B2ListFileNamesResponseContent() { }
    }
}
