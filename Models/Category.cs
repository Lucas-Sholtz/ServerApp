using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Category
    {
        public Category(int Id,string Caption, string Description)
        {
            this.Id = Id;
            this.Caption = Caption;
            this.Description = Description;
        }
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
    }
}
