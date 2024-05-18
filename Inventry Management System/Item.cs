using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventry_Management_System
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Item(int id) { this.id = id; }   
        public Item(int id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return $"Id:{id},Name:{name},Price:{price},Quantity:{quantity}";
        }
    }
}
