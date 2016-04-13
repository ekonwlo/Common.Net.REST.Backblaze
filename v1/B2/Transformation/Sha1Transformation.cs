using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Backblaze.v1.B2.Transformation
{
    class Sha1Transformation
        : IRestTransformation<byte[], string>
    {
        public string Transform(byte[] input)
        {
            StringBuilder builder = new StringBuilder();
            
            foreach (byte b in input)
                builder.Append(b.ToString("x2"));

            string ssss = builder.ToString();
            //string ssss = Encoding.UTF8.GetString(input);

            return ssss;
        }

        public byte[] Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
