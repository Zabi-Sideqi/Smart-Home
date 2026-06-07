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




        }
    }
}

/*
1. Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance?

Eftersom Appliance inte har metoden Schedule().
Bara klasser som implementerar ISchedulable har den metoden.

2. Vad gör interface-kontrollen med "is"?

Den kontrollerar om objektet implementerar ISchedulable.

3. Varför behöver vi casta till ISchedulable?

För att kunna använda Schedule()-metoden.

4. Vilka apparater blev schemalagda?

Washer, RobotVacuum och CoffeeMachine.

5. Varför blev inte Refrigerator, Oven och AirConditioner schemalagda?

Eftersom de inte implementerar ISchedulable.
*/
