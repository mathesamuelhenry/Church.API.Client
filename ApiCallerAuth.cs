using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerAuth : ApiCallerBase
    {
        public ApiCallerAuth(string uri) :
            base(uri)
        {

        }

        public Users RegisterUser(Users user)
        {
            string url = $"api/Users/Register";

            var userInfo = ApiHelper.CallPostWebApi<Users>(url, user);

            return userInfo;
        }
    }
}
