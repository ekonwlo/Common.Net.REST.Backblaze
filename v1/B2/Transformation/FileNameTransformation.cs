using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Backblaze.v1.B2.Transformation
{
    class FileNameTransformation
        : IRestTransformation<string, string>
    {
        public string Transform(string input)
        {

            string ssss = HttpUtility.UrlEncode(input);

            return HttpUtility.UrlEncode(input);
        }

        public string Revert(string input)
        {
            return HttpUtility.UrlDecode(input);
        }
    }
}
