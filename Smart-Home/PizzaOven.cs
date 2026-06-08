using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    public class PizzaOven : Oven
    {
        public PizzaOven(string brand, string room, int maxTemperature)
        : base(brand, room, maxTemperature)
        {
        } 

        public override void TurnOn()
        {
            Console.WriteLine("Pizza oven starts at extra high temperature.");
        }
    }
}
