using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Backblaze.v1.B2.Transformation
{
    class AuthorizationTransformation
        : IRestTransformation<B2AuthorizationCredentials, string>
    {
        public string Transform(B2AuthorizationCredentials input)
        {
            return "Basic" + Convert.ToBase64String(Encoding.UTF8.GetBytes(input.AccountId + ":" + input.ApplicationKey));
        }

        public B2AuthorizationCredentials Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
