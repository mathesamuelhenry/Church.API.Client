using Church.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Client
{
    public class ApiCallerTransaction : ApiCallerBase
    {
        public ApiCallerTransaction(string uri) :
            base(uri)
        {
        }

        public List<Contribution> GetTransactions()
        {
            string url = $"api/Transactions";

            var transactionList = ApiHelper.CallGetWebApi<List<Contribution>>(url);

            return transactionList;
        }

        public Contribution GetTransaction(int id = 0)
        {
            string url = $"api/Transactions/{id}";

            var transaction = ApiHelper.CallGetWebApi<Contribution>(url);

            return transaction;
        }

        public Dictionary<string, decimal> GetAccountBalance()
        {
            string url = $"api/Transactions/GetAccountBalance";

            var accountBalanceList = ApiHelper.CallGetWebApi<Dictionary<string, decimal>>(url);

            return accountBalanceList;
        }
    }
}
