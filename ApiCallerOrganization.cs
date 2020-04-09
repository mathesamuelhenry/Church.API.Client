using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerOrganization : ApiCallerBase
    {
        public ApiCallerOrganization(string uri) :
            base(uri)
        {

        }

        public List<Organization> GetOrganizations()
        {
            string url = $"api/Organizations";

            var result = ApiHelper.CallGetWebApi<List<Organization>>(url);

            return result;
        }

        public Organization GetOrganizationById(int id)
        {
            string url = $"api/Organizations/{id}";

            var result = ApiHelper.CallGetWebApi<Organization>(url);

            return result;
        }

        public Organization PostAddOrganization(Organization orgRequest)
        {
            string url = $"api/Organizations";

            var result = ApiHelper.CallPostWebApi<Organization, Organization>(url, orgRequest);

            return result;
        }
    }
}
