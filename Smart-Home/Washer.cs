using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    internal class Washer
    {
        public string Brand { get; set; }
        public int CapacityKg { get; set; }

        public Washer(string brand, int capacityKg)
        {
            Brand = brand;
            CapacityKg = capacityKg;
        }
        public void StartWash()
        {
            Console.WriteLine($"{Brand} washer starts washing.");
        }
        public void StopWash()
        {
            Console.WriteLine($"{Brand} washer stops washing.");
        }
        public void PrintWashEnergy()
        {
            Console.WriteLine($"{Brand} washer uses 1.2 kWh per wash.");
        }
    }
}
