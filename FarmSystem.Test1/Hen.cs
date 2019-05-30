using System;

namespace FarmSystem.Test
{
    public class Hen : Animal
    {

        public Hen() : base("Hen", 2)
        {

        }
        
        public  void Talk() => Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");

       

    }
}