using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Product
    {
        public Product(int Id, int GroupId, string Caption, string Image)
        {
            this.Id = Id;
            this.GroupId = GroupId;
            this.Caption = Caption;
            this.Image = Image;
        }
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }
}
