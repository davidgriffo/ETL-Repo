using System;

namespace FarmSystem.Test
{

    public abstract class Animal
    {
        public Animal(string _name, int _noOfLegs)
        {
            NoOfLegs = _noOfLegs;
            Id = Guid.NewGuid().ToString();
            AnimalType = _name;
        }
        public string AnimalType { get; set; }
        public string Id { get; set; }
        public int NoOfLegs { get; set; }

        public virtual void Run()
        {
            Console.WriteLine($"{AnimalType} is running");
        }

        public virtual void Walk()
        {
            Console.WriteLine($"{AnimalType} is walking");
        }
        public virtual void Talk()
        {
            Console.WriteLine($"{AnimalType} can not talk!");
        }
    }
}
