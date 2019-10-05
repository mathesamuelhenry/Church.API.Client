using System;
using System.Collections.Generic;
using System.Text;
using Church.API.Models;

namespace Church.API.Client
{
    public class ApiCallerCVD : ApiCallerBase
    {
        public ApiCallerCVD(string uri) :
            base(uri)
        {

        }

        public List<ColumnValueDesc> GetColumnValueDescList(string tableName, string columnName)
        {
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(columnName))
            {
                throw new Exception("Table Name and Column Name must not be empty");
            }
            else
            {
                string url = $"api/ColumnValueDesc/GetCVD/{tableName}/{columnName}";

                var cvdList = ApiHelper.CallGetWebApi<List<ColumnValueDesc>>(url);

                return cvdList;
            }
        }
    }
}
