using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class InventoryTest
    {
        Item myItem;
        Inventory myInventory = new Inventory(5);

        [SetUp]
        public void Setup()
        {
            myItem = new Item ("AAA", 55, ItemType.key);
         
        }

        [Test]
        public void TestAdd()
        {
            myInventory.Add(myItem);
            Assert.AreEqual(myItem.Name, myInventory.items[0].Name);
        }

        [Test]
        public void TestRemove()
        {
            myInventory.Add(myItem);
            Assert.IsTrue(myInventory.Remove(myItem));
           
        }

    }
}