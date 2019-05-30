using System;

namespace FarmSystem.Test
{
    public class Sheep : Animal
    {
        public Sheep() : base(_name: "Sheep", _noOfLegs: 4) { }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
              

    }

}