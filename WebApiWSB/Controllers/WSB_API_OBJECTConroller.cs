using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWSB.Models;

namespace WebApiWSB.Controllers
{
    [Route("wsb_api_object")]
    [ApiController]
    public class WSB_API_OBJECTConroller : ControllerBase
    {
        [HttpGet]
        public List<WSB_API_OBJECT> getWsbObjects()
        {
            return WSB_API_OBJECT.getWsbObjects();
        }

        [HttpPost]
        public WSB_API_OBJECT addWsbObject(WSB_API_OBJECT newObject)
        {
            return WSB_API_OBJECT.addWsbObject(newObject);
        }

        [HttpDelete]
        public bool deleteWsbObject(int id)
        {
            return WSB_API_OBJECT.deleteWsbObject(id);
        }
    }
}
