using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    public class B2DeleteFileVersionRequestContent
    {
        //The unique ID of the file version that was deleted.
        [RestContent("fileId")]
        public string FileId { get; internal set; }

        //The name of the file.
        [RestContent("fileName")]
        public string FileName { get; internal set; }

        public B2DeleteFileVersionRequestContent(string fileId, string fileName) 
        {
            FileId = fileId;
            FileName = fileName;
        }
    }
}
