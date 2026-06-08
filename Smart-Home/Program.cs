using System;
using System.Collections.Generic;

namespace Smart_Home
{
    internal class Program
    {
        static void Main()
        {
            SmartHomeController controller = new SmartHomeController();

            
            // Lägg till minst fem olika apparater. 
            controller.AddDevice(new Washer("LG", "Laundry Room", 7));
            controller.AddDevice(new Refrigerator("Samsung", "Kitchen", 8));
            controller.AddDevice(new Oven("ElectroLux", "Kitchen", 250));
            controller.AddDevice(new RobotVacuum("Xiaomi", "Living Room", 80));
            controller.AddDevice(new AirConditioner("Daikin", "Bedroom", 16));
            controller.AddDevice(new CoffeeMachine("Philips", "Kitchen", 6));



            controller.PrintStatusReport();

            Console.WriteLine();

            controller.TurnOnAll();

            Console.WriteLine();



            controller.ScheduleAllSchedulableDevices
                (DateTime.Now.AddHours(2));
            double totalEnergy = controller.GetTotalDailyEnergyUsage();
            
            Console.WriteLine($"Total daily energy usage: {totalEnergy} kWh");

            controller.TurnOffAll();
            

            Console.WriteLine();


            SmartLamp lamp1 = new SmartLamp("IKEA", "Hallway", 80);
            Appliance lamp2 = lamp1;
            lamp1.TurnOn();
            lamp2.TurnOn();


        }

    }
}


/*
Del 12

1. Vad säger kompilatorn?

Kompilatorn säger att PizzaOven inte kan override:a
TurnOn() eftersom metoden är sealed i Oven.

2. Varför får PizzaOven inte override:a TurnOn()?

Eftersom Oven har markerat TurnOn() med sealed override.
Då får inga klasser som ärver från Oven ändra metoden.

3. När kan det vara rimligt att använda sealed override?

När man vill låsa ett beteende så att framtida
child classes inte kan ändra det.

4. Vad kan PizzaOven fortfarande göra i stället?

PizzaOven kan fortfarande override:a andra metoder
som inte är sealed, till exempel GetInfo()
eller GetDailyEnergyUsage().
*/