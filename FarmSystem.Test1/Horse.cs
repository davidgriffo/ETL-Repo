﻿using System;

namespace FarmSystem.Test
{
    public class Horse : Animal
    {
        public Horse() : base(_name: "Horse", _noOfLegs: 4) { }
       


        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

      
    }
}