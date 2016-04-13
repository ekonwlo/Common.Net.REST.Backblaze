using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2DeleteFileVersionResponseContent
    {
        //The unique ID of the file version that was deleted.
        [RestContent("fileId")]
        public string FileId { get; internal set; }

        //The name of the file.
        [RestContent("fileName")]
        public string FileName { get; internal set; }
       
        internal B2DeleteFileVersionResponseContent() { }
    }
}
