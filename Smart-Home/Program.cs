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
            List<ISchedulable> schedulableDevices = controller.GetSchedulableDevices();
            foreach (ISchedulable schedulable in schedulableDevices)
            {
                
                // Skriv ut NextRun eller schemalägg apparaten. 
                Console.WriteLine($"Next run: {schedulable.NextRun}");
            }
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


