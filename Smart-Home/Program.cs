using System;
using System.Collections.Generic;

namespace Smart_Home
{
    internal class Program
    {
        static void Main()
        {
            List<Appliance> devices = new List<Appliance>();

            devices.Add(new Washer("LG", "Laundry Room", 7));
            devices.Add(new Refrigerator("Samsung", "Kitchen", 8));
            devices.Add(new Oven("ElectroLux", "Kitchen", 250));
            devices.Add(new RobotVacuum("Xiaomi", "Living Room", 80));
            devices.Add(new CoffeeMachine("Philips", "Kitchen", 6));

            foreach (Appliance device in devices)

            {
                Console.WriteLine(device.GetInfo());
                device.TurnOn();
                Console.WriteLine($"Daily energy usage: {device.GetDailyEnergyUsage()} kWh");
                device.TurnOff();
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}



/*
1. Varför fungerar device.TurnOn() trots att device har typen Appliance?

Det fungerar eftersom TurnOn() finns i Appliance.
C# använder polymorfism och kör rätt metod för den apparat som finns i objektet.

2. Vilken metod körs om objektet egentligen är en RobotVacuum?

Då körs RobotVacuums TurnOn()-metod.
Det är inte Appliance-metoden som körs.

3. Vad blev bättre jämfört med List<object>?

Koden blev enklare att skriva och läsa.
Vi behöver inte använda if, is eller casting för varje apparat.
Det blir också lättare att lägga till nya apparater.
*/