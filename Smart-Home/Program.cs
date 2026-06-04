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

            devices.Add(oven);
            devices.Add(washer);
            devices.Add(refrigerator);
            devices.Add(robotVacuum);

            RunMorningRoutine(devices);

            Console.WriteLine();

            ReportAllEnergy(devices);

            Console.ReadLine();
        }

        static void RunMorningRoutine(List<object> devices)
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
            }
        }
    }
}


/*
1. Varför behövde du kontrollera vilken typ varje objekt hade?
Svar: Eftersom listan är List<object> vet programmet inte vilken typ objekten har.

2. Vad händer om du lägger till en ny klass CoffeeMachine?
Svar: Jag måste lägga till nya if-satser för CoffeeMachine.

3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?
Svar: RunMorningRoutine() och ReportAllEnergy().

4. Vad är problemet med att listan är List<object>?
Svar: Alla objekt behandlas som object och måste typkontrolleras och castas.

5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
Svar: Den apparatens energiförbrukning kommer inte att visas.
*/