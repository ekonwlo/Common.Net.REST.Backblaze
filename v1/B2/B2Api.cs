using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST;

namespace Common.Net.REST.Backblaze.v1.B2
{
    using B2;

    public static class B2Api
    {
        public static void Initialize()
        {
            RestRequestFactory.Initialize<B2AuthorizeAccountRequest>();
            
            RestRequestFactory.Initialize<B2ListBucketsRequest>();
            RestRequestFactory.Initialize<B2CreateBucketRequest>();
            RestRequestFactory.Initialize<B2UpdateBucketRequest>();
            RestRequestFactory.Initialize<B2DeleteBucketRequest>();

            RestRequestFactory.Initialize<B2ListFileNamesRequest>();
            RestRequestFactory.Initialize<B2ListFileVersionsRequest>();
            RestRequestFactory.Initialize<B2GetFileInfoRequest>();
            RestRequestFactory.Initialize<B2GetUploadUrlRequest>();
            RestRequestFactory.Initialize<B2UploadFileRequest>();
            RestRequestFactory.Initialize<B2DeleteFileVersionRequest>();
            RestRequestFactory.Initialize<B2HideFileRequest>();
        }
    }
}
