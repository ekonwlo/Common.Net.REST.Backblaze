using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2FileInfoRequestContent
    {
        [RestContent("fileId")]
        public string FileId { get; internal set; }

        public B2FileInfoRequestContent(string fileId)
        {
            this.FileId = fileId;
        }
    }
}
