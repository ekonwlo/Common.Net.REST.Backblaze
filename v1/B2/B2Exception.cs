﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Common.Net.REST;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using Attributes;
	using Content;

    public class B2Exception
        : RestException
    {

        [RestContent("content")]    
        public B2ExceptionContent Content { get; private set; }
        
        protected internal B2Exception()
            : base()
        { }

        protected internal B2Exception(string message)
            : base(message)
        { }

        protected internal B2Exception(string message, Exception innerException)
            : base(message, innerException)
        { }

        protected internal B2Exception(SerializationInfo info, StreamingContext context)
            : base()
        { }

        public override string ToString()
        {
            if (Content == null)
                return base.ToString();

            return string.Format("B2Excepton: {0} ({1}) - {2}", Content.Code, Content.Status, Content.Message);
        }
    }
}
