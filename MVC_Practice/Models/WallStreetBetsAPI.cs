using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC_Practice.Models
{
    public class WallStreetBetsAPI
    {
        private static HttpClient _realClient = null;

        public static HttpClient MyHttp
        {
            get
            {
                if (_realClient == null)
                {
                    _realClient = new HttpClient();
                    _realClient.BaseAddress = new Uri("https://dashboard.nbshare.io/");
                }
                return _realClient;
            }
        }

        
        public static async Task<WSB_Object> GetWSBObject(string ticker)
        {
            var connection = await MyHttp.GetAsync("/api/v1/apps/reddit");
            List<WSB_Object> wsbObjects = await connection.Content.ReadAsAsync<List<WSB_Object>>();

            WSB_Object myWSBobject = new WSB_Object();

            for (int i = 0; i < wsbObjects.Count; i++)
            {
                if (wsbObjects[i].ticker.ToLower() == ticker.ToLower())
                {
                    myWSBobject = wsbObjects[i];
                }
            }
            return myWSBobject;
        }
    }
}
