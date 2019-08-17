using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerMember : ApiCallerBase
    {
        public ApiCallerMember(string uri) :
            base(uri)
        {
        }

        public List<Contributor> GetContributors()
        {
            string url = $"api/Member";

            var contributorList = ApiHelper.CallGetWebApi<List<Contributor>>(url);

            return contributorList;
        }

        public Contributor GetContributorById(int id = 0)
        {
            if (id == default(int))
            {
                throw new Exception("Please pass a valid id");
            }

            string url = $"api/Contributor/{id}";

            var contributor = ApiHelper.CallGetWebApi<Contributor>(url);

            return contributor;
        }

        public List<string> GetAllFullNames()
        {
            string url = $"api/Contributor/GetFullNames";

            var contributorList = ApiHelper.CallGetWebApi<List<string>>(url);

            return contributorList;
        }

    }
}
