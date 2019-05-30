using System;

namespace FarmSystem.Test
{
    public class Cow : Animal, IMilkableAnimal
    {
        public Cow() : base(_name: "Cow", _noOfLegs: 4) { }
        

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public  void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }
              

    }
}