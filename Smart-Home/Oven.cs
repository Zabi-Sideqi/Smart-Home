using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    internal class Oven
    {
        public string Brand { get; set; }
        public int MaxTemperature { get; set; }

        public Oven(string brand, int maxTemperature)
        {
            Brand = brand;
            MaxTemperature = maxTemperature;
        }

        public void StartHeating()
        {
            Console.WriteLine($"{Brand} oven is starts heating.");

        }
        public void StopHeating()
        {
            Console.WriteLine($"{Brand} oven has stops heating.");
        }
        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"{Brand} oven uses 2.5 kWh per hour .");
        }
       
    }
}
