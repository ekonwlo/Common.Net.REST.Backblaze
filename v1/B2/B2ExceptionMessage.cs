﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;

    [Serializable()]
    public class B2ExceptionMessage
    {
        [RestContent("code")]
        public string Code { get; private set; }

        [RestContent("message")]
        public string Message { get; private set; }

        [RestContent("status")]
        public int Status { get; private set; }

        private B2ExceptionMessage() { }

        //protected internal B2Exception(SerializationInfo info, StreamingContext context) '{ }
        
    }
}
