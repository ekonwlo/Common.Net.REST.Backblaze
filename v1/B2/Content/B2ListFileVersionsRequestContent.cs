using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2ListFileVersionsRequestContent
        : B2ListFileNamesRequestContent
    {
        [RestContent("startFileId", Mandatory = false)]
        public string StartFileId { get; internal set; }

        public B2ListFileVersionsRequestContent(string bucketId, int @maxFileCount = 100) : base(bucketId) { }

        public B2ListFileVersionsRequestContent(string bucketId, string startFileName, string startFileId, int @maxFileCount = 100)
            : base(bucketId, startFileName, @maxFileCount)
        {
            StartFileId = startFileId;
        }

    }
}
