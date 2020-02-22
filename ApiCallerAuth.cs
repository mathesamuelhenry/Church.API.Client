using Church.API.Models;
using Church.API.Models.AppModel.Request;
using Church.API.Models.AppModel.Request.User;
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

        public Users RegisterUser(RegisterRequest userRequest)
        {
            string url = $"api/Users/Register";

            var userInfo = ApiHelper.CallPostWebApi<RegisterRequest, Users>(url, userRequest);

            return userInfo;
        }

        public Users UserAuthenticate(SignInRequest signInRequest)
        {
            string url = $"api/Users/Authenticate";

            var userInfo = ApiHelper.CallPostWebApi<SignInRequest, Users>(url, signInRequest);

            return userInfo;
        }
    }
}
