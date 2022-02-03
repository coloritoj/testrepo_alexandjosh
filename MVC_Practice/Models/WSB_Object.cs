using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practice.Models
{
    public class WSB_Object
    {
        public int no_of_comments { get; set; }
        public string sentiment { get; set; }
        public decimal sentiment_score { get; set; }
        public string ticker { get; set; }
    }
}
