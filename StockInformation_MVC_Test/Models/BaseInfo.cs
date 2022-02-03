using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockInformation_MVC_Test.Models
{
    public class BaseInfo
    {
        public Pagination pagination { get; set; }
        public List<StockInfo> data { get; set; }
    }
}
