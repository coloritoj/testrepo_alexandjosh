using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace StockInformation_MVC_Test.Models
{
    public class CallAPI
    {
        private static HttpClient _theRealClient = null;

        public static HttpClient HttpClient
        {
            get
            {
                if (_theRealClient == null)
                {
                    _theRealClient = new HttpClient();
                    _theRealClient.BaseAddress = new Uri("http://api.marketstack.com/v1/eod");
                }
                return _theRealClient;
            }
            
        }

        public static async Task<BaseInfo> GetInfo(string apiKey, string theTicker)
        {
            var connection = await HttpClient.GetAsync($"?access_key={apiKey}&symbols={theTicker}");
            BaseInfo myBaseInfo = await connection.Content.ReadAsAsync<BaseInfo>();
            return myBaseInfo;
        }
    }


 
}
