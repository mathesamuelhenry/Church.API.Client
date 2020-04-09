using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerIndustry : ApiCallerBase
    {
        public ApiCallerIndustry(string uri) :
            base(uri)
        {

        }

        public List<Industry> GetAll()
        {
            string url = $"api/Industries";

            var result = ApiHelper.CallGetWebApi<List<Industry>>(url);

            return result;
        }

        public Industry GetIndustryById(int id)
        {
            string url = $"api/Industries/{id}";

            var result = ApiHelper.CallGetWebApi<Industry>(url);

            return result;
        }
    }
}
