namespace Smart_Home
{
    public class CoffeeMachine : Appliance, ISchedulable
    {
        public int CupsPerBrew { get; set; }

        public DateTime NextRun { get; set; }
        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} coffee machine scheduled to brew at {NextRun}.");
        }

        public CoffeeMachine(string brand, string room, int cupsPerBrew)
            : base(brand, room)
        {
            // Anropa basklassens konstruktor. 
            // Sätt CupsPerBrew. 
            CupsPerBrew = cupsPerBrew;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} with a capacity of {CupsPerBrew} cups per brew";
        }

        public override void TurnOn()
        {
            IsOn = true ;
            Console.WriteLine($"{Brand} coffee machine starts brewing.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} coffee machine stops brewing.");
        }

    public override double GetDailyEnergyUsage()
        {
            // Anta att varje bryggning använder 0.1 kWh per kopp. 
            return 0.3;
        }

    }
}