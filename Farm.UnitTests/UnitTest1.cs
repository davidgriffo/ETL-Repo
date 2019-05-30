using System;
using FarmSystem.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farm.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCowsAreMilkable()
        {
            //arrange
            var cow = new Cow();
            //act
            //assert
            Assert.IsTrue(cow.NoOfLegs == 4);
            Assert.IsTrue(cow.AnimalType == "Cow");
            Assert.IsNotNull(cow.Id, "id should not be null!");
            Assert.IsTrue(cow is IMilkableAnimal);

        }
        [TestMethod]
        public void TestAnimals()
        {
            var horse = new Horse();
            Assert.IsFalse(horse is IMilkableAnimal);

            var chook = new Hen();
            Assert.IsTrue(chook.NoOfLegs == 2);
            Assert.IsFalse(chook is IMilkableAnimal);

        }
    }
}
