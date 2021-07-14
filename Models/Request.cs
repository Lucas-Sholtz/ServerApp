using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Request
    {
        public string CalcId { get; set; }
        public string Args { get; set; }
        public string Ticket { get; set; }
    }
}
