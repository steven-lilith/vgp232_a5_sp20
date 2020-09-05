using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class CharacterTest
    {
        Character myCharacter;

        [SetUp]
        public void Setup()
        {
            myCharacter = new Character("AAA", RaceCatagory.Human, 100);
        }

        [Test]
        public void TestDamageCharacter()
        {
            myCharacter.TakeDamage(1);
            Assert.AreEqual(99, myCharacter.HealthPoints);
        }
        [Test]
        public void TestRestoreHealth()
        {
            myCharacter.TakeDamage(1);
            myCharacter.RestoreHealth(1);
            Assert.AreEqual(100, myCharacter.HealthPoints);
        }


    }
}