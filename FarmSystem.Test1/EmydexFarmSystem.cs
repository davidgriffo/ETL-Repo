using System;
using System.Collections.Generic;

namespace FarmSystem.Test
{
    public class EmydexFarmSystem
    {
        private System.Collections.Generic.List<Animal> farmAnimals;

        public EmydexFarmSystem()
        {
            this.farmAnimals = new List<Animal>();
        }

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            if (animal != null)
            {
                farmAnimals.Add(animal);
                Console.WriteLine($"{animal.AnimalType} has entered the Emydex farm");
            }
            else
            {
                Console.WriteLine($"this animal is a null and does not belong in the farm (it has been shot)");
            }
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (farmAnimals.Count > 0)
            {
                foreach (var animal in farmAnimals)
                {
                    animal.Talk();
                }
            }
            else
                Console.WriteLine("There are no animals in the farm");

        }

        //TEST 3
        public void MilkAnimals()
        {
            var counter = 0;
            foreach (var animal in farmAnimals)
            {
                if (animal is IMilkableAnimal)
                {
                    counter += 1;
                    var milkingcow = (IMilkableAnimal)animal;
                    milkingcow.ProduceMilk();
                }
            }
            // this line removed as it is not part of the requested output.
            //Console.WriteLine($"{counter} animals were milked!");
          
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (var animal in farmAnimals)
            {
                Console.WriteLine($"{animal.AnimalType} has left the farm");
               
            }
            farmAnimals.Clear();
            if (farmAnimals.Count > 0)
                Console.WriteLine($"There are {farmAnimals.Count} animals in the farm");
            else
                Console.WriteLine("Emydex Farm is now empty");
        }
    }
}