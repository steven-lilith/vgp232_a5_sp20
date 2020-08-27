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

            Console.WriteLine("Welcome to the Adventure of Assignment 5");

            Character myCharacter = new Character("Bob", RaceCatagory.Elf, 100);

            myCharacter.TakeDamage(10);

            myCharacter.RestoreHealth(10);

            Console.WriteLine("The game has ended with {0} with {1} health", myCharacter.Name, myCharacter.HealthPoints);

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
