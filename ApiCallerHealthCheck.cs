using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerHealthCheck : ApiCallerBase
    {
        public ApiCallerHealthCheck(string uri) :
            base(uri)
        {
        }

        public bool ApiHealthy()
        {
            string url = $"healthcheck";

            var healthCheckString = ApiHelper.CallGetWebApiResultContent(url);

            return healthCheckString == "Healthy";
        }
    }
}
