using Microsoft.AspNetCore.Mvc;
using NPOI.SS.Formula.Functions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace BuggyCarsRatingUIAutomation
{
    class APIRequest
    {

        public async Task<IRestResponse> GetBuggyCarRequest()
        {
            string BaseUrl = "http://buggy.justtestit.org/";
            IRestClient client = new RestClient(BaseUrl);
            client.Proxy = new WebProxy();            
            client.AddDefaultHeader("Connection", "keep-alive");
            IRestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic Og==");
            request.AddHeader("Content-Type", "text/html");
            request.AddHeader("Connection", "Keep-Alive");
            request.Timeout = 5000;            
            return await ExecuteAsynctRequest<T>(client, request);
         
        }


        /// <summary>
        /// Contection was closed so tried this method 
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<IRestResponse> ExecuteAsynctRequest<T>(IRestClient client, IRestRequest request) where T : class, new ()
        {
            var tcs = new TaskCompletionSource<T>();
            client.ExecuteAsync<T>(request, restresponse =>
             {
                 if (restresponse.ErrorException != null)
                 {
                     const string message = "Error retrieving response.";
                     throw new ApplicationException(message, restresponse.ErrorException);
                 }
                 tcs.SetResult(restresponse.Data);
             });
            return await tcs.Task as IRestResponse<T>;
        }

        
        public async Task<IRestResponse> GetBuggyCarApi()
        {
            string BaseUrl = "https://buggy.justtestit.org/";
            IRestClient client = new RestClient(BaseUrl);
            client.Proxy = new WebProxy();                      
            client.AddDefaultHeader("Connection", "keep-alive");            
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic Og==");
            request.AddHeader("Content-Type", "text/html");
            request.AddHeader("Connection", "Keep-Alive");                                 
            var response = await client.ExecuteGetAsync<Method>(request);            
            return response;
        }


        public Task<WebResponse> GetBuggyCarsHttpWebRequest()
        {
            string BaseUrl = "https://buggy.justtestit.org/";
            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create(BaseUrl);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            request1.Proxy = new WebProxy();
            request1.KeepAlive = true;
            request1.Method = "GET";
            request1.Connection = "OPEN";
            return request1.GetResponseAsync();
        }



    }
}
