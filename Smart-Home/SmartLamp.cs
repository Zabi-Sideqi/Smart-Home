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
