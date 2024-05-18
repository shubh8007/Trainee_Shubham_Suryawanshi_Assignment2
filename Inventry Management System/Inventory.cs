using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventry_Management_System
{
    public class Inventory
    {
        private List<Item> items;
        public Inventory() { 
        
        items= new List<Item>();
        }
        public void addItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Item Added Sucessfully");
        }

       
         public void getItems()
        {
            foreach  (Item item in items)
            {
                Console.WriteLine(item);
            }
        }

        public Item GetItemById(int id)
        {
            return items.Find(item => item.id == id);
        }

        public bool updateItem(int id, string name, double price, int quantity) { 
        
            Item item=GetItemById(id);
            if (item != null) {

              item.name = name;
                item.price = price;
                item.quantity = quantity;
                return true;


            }
            return false;
        
        }



        public bool deleteItem(int id)
        {
            Item item=GetItemById(id);
            if(item != null) {

                items.Remove(item);
            }
            return false;
        }

    }
}
