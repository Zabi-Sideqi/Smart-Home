using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
   public class SmartLamp : Appliance
    {
        public int Brightness { get; set; }
        public SmartLamp(string brand, string room, int brightness)
        : base(brand, room)
        {
            
            // Spara brightness.
            Brightness = brightness;
        }
        public new void TurnOn()
        {

            // Skriv ut att lampan tänds. 
            Console.WriteLine($"{ Brand} SmartLamp turned on with brightness {Brightness}%.");
        }

    }
}
/*
1. Blir utskriften samma?

Nej, utskriften blir olika.

2. Vilken metod körs när variabeln har typen SmartLamp?

SmartLamp.TurnOn() körs.

3. Vilken metod körs när variabeln har typen Appliance?

Appliance.TurnOn() körs.

4. Varför är detta farligt eller förvirrande?

Samma objekt kan ge olika resultat beroende på vilken typ variabeln har.
Det kan göra koden svårare att förstå.

5. Vad händer om du byter new till override?

Då används polymorfism.
Båda anropen skulle köra SmartLamp.TurnOn().
*/ 