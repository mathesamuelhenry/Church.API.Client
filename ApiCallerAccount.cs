using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerAccount : ApiCallerBase
    {
        public ApiCallerAccount(string uri) :
            base(uri)
        {

        }

        public List<Account> GetAccounts()
        {
            string url = $"api/Accounts";

            var accountList = ApiHelper.CallGetWebApi<List<Account>>(url);

            return accountList;
        }
    }
}
