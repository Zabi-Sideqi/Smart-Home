using System;
using System.Collections.Generic;

namespace Smart_Home
{
    internal class Program
    {
        static void Main()
        {
            List<object> devices = new List<object>();

            Oven oven = new Oven("Electrolux", 250);
            Washer washer = new Washer("LG", 7);
            Refrigerator refrigerator = new Refrigerator("Samsung", 4);
            RobotVacuum robotVacuum = new RobotVacuum("Xiaomi", 80);
            Coffeemachine coffeeMachine = new Coffeemachine("Philips", 6);

            devices.Add(oven);
            devices.Add(washer);
            devices.Add(refrigerator);
            devices.Add(robotVacuum);
            devices.Add(coffeeMachine);

            RunMorrningRoutine(devices);

            Console.WriteLine();

            ReportAllEnergy(devices);

            Console.ReadLine();
        }

        static void RunMorrningRoutine(List<object> devices)
        {
            foreach (object device in devices)
            {
                if (device is Washer washer)
                {
                    washer.StartWash();
                    washer.StopWash();
                }
                else if (device is Oven oven)
                {
                    oven.StartHeating();
                    oven.StopHeating();
                }
                else if (device is Refrigerator refrigerator)
                {
                    refrigerator.StartCooling();
                    refrigerator.StopCooling();
                }
                else if (device is RobotVacuum robotVacuum)
                {
                    robotVacuum.StartCleaning();
                    robotVacuum.StopCleaning();
                }
                else if (device is Coffeemachine coffeeMachine)
                {
                    coffeeMachine.StartBrewing();
                    coffeeMachine.StopBrewing();
                }
            }
        }

        static void ReportAllEnergy(List<object> devices)
        {
            foreach (object device in devices)
            {
                if (device is Washer washer)
                {
                    washer.PrintWashEnergy();
                }
                else if (device is Oven oven)
                {
                    oven.PrintHeatingEnergy();
                }
                else if (device is Refrigerator refrigerator)
                {
                    refrigerator.PrintCoolingEnergy();
                }
                else if (device is RobotVacuum robotVacuum)
                {
                    robotVacuum.PrintCleaningEnergy();
                }
                else if (device is Coffeemachine coffeeMachine)
                {
                    coffeeMachine.PrintBrewingEnergy();
                }
            }
        }
    }
}


/*
När jag lade till CoffeeMachine behövde jag ändra 3 ställen:

1. Skapa klassen CoffeeMachine.
2. Lägga till CoffeeMachine i RunMorningRoutine().
3. Lägga till CoffeeMachine i ReportAllEnergy().

Det är ett problem eftersom man måste ändra flera metoder varje gång en ny apparat läggs till.
*/
