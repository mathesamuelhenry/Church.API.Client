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

        public List<Contributor> GetMembers()
        {
            string url = $"api/Member";

            var memberList = ApiHelper.CallGetWebApi<List<Contributor>>(url);

            return memberList;
        }

        public Contributor GetMemberById(int id = 0)
        {
            if (id == default(int))
            {
                throw new Exception("Please pass a valid id");
            }

            string url = $"api/Member/{id}";

            var member = ApiHelper.CallGetWebApi<Contributor>(url);

            return member;
        }

        public List<string> GetAllFullNames()
        {
            string url = $"api/Member/GetFullNames";

            var memberList = ApiHelper.CallGetWebApi<List<string>>(url);

            return memberList;
        }

        public Contributor DeleteMember(int id)
        {
            string url = $"api/Member/{id}";

            var member = ApiHelper.CallDeleteWebApi<Contributor>(url);

            return member;
        }
    }
}
