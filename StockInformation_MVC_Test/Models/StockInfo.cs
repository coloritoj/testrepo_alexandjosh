using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockInformation_MVC_Test.Models
{
    public class StockInfo
    {
        public string symbol { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double volume { get; set; }
        public DateTime date { get; set; }
    }
}
