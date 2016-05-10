using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Common.Net.REST.Backblaze.v1.B2.Content
{
    using Attributes;

    [Serializable()]
    public class B2ExceptionContent
    {
        [RestContent("code")]
        public string Code { get; private set; }

        [RestContent("message")]
        public string Message { get; private set; }

        [RestContent("status")]
        public int Status { get; private set; }

        private B2ExceptionContent() { }

        //protected internal B2Exception(SerializationInfo info, StreamingContext context) '{ }
        
    }
}
