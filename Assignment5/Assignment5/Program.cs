using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(3);
            Item tst1= new Item("test1",5,ItemType.consumable);
            Item tst2 = new Item("test2", 5, ItemType.key);
            Item tst3 = new Item("test3", 5, ItemType.equipment);
            inventory.Add(tst1);
            inventory.Add(tst2);
            inventory.Add(tst3);
            inventory.ShowInventory();
            inventory.Remove(tst1);
            inventory.ShowInventory();
            
     
            // TODO: initialize the inventory
            // Add a few items
            // Remove a few items
            // show the inventory.

        }
    }
}
