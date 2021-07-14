using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Order
    {
        public Order(int StageId, int ProductId, double Price, int Amount)
        {
            //generate random date from 2021/01/11 till today
            Random gen = new Random();
            DateTime start = new DateTime(2021, 7, 11);
            int range = (DateTime.Today - start).Days;
            DateTime orderDate = start.AddDays(gen.Next(range));

            Date = orderDate;
            this.StageId = StageId;
            this.ProductId = ProductId;
            this.Price = Price;
            this.Amount = Amount;
        }
        public DateTime Date { get; set; }
        public int StageId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
