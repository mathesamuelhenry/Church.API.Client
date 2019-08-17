using System;

namespace Church.API.Client
{
    public class ApiCallerBase
    {
        public ApiCallerBase(string uri)
        {
            ApiHelper.InitializeClient(uri);
        }
    }
}
