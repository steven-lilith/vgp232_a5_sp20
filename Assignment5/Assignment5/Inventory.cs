using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int slots;
        public List<Item> items;

        public Inventory(int s)
        {
            items = new List<Item>(s);
            slots = s;
        }

        public void Add(Item item)
        {
            if(items.Count>=slots)
            {
                Console.WriteLine("inventory is full");
                return;
            }
            items.Add(item);
        }

        public bool Remove(Item item)
        {
            if(items.Contains(item)==false)
            {
                Console.WriteLine("cannot find item in the inventory");
            }
            return items.Remove(item);
        }

        public void ShowInventory()
        {
            for (int i=0;i<items.Count; ++i)
            {
                Console.WriteLine("Name:" + items[i].Name);
                Console.WriteLine("Type:" + items[i].IType);
                Console.WriteLine("Modifier:" + items[i].Modifier);
            }
        }
    }
}
