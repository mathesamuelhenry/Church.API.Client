using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerUserOrganization : ApiCallerBase
    {
        public ApiCallerUserOrganization(string uri) :
            base(uri)
        {

        }

        public List<UserOrganization> GetUserOrganizations()
        {
            string url = $"api/UserOrganizations";

            var result = ApiHelper.CallGetWebApi<List<UserOrganization>>(url);

            return result;
        }

        public UserOrganization GetUserOrganizationById(int id)
        {
            string url = $"api/UserOrganizations/{id}";

            var result = ApiHelper.CallGetWebApi<UserOrganization>(url);

            return result;
        }

        public UserOrganization PostAddUserOrganization(UserOrganization userOrgRequest)
        {
            string url = $"api/UserOrganizations";

            var result = ApiHelper.CallPostWebApi<UserOrganization, UserOrganization>(url, userOrgRequest);

            return result;
        }
    }
}
