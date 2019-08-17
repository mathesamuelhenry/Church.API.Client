using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Church.API.Client
{
    public static partial class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient(string uri)
        {
            if (ApiClient == null)
            {
                ApiClient = new HttpClient();
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                ApiClient.BaseAddress = new Uri(uri);
            }
        }

        public static T CallGetWebApi<T>(string url)
        {
            using (HttpResponseMessage response = ApiHelper.ApiClient.GetAsync(url).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(data);
                }
                else
                {
                    // var resultMessage = JsonConvert.DeserializeObject<Message>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                    // throw new Exception(resultMessage.message);
                    throw new Exception("");
                }
            }
        }
    }
}
