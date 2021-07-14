using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class OrderStage
    {
        public OrderStage(int Id, string Caption)
        {
            this.Id = Id;
            this.Caption = Caption;
        }
        public int Id { get; set; }
        public string Caption { get; set; }
    }
}
