namespace Smart_Home
{
    internal class Coffeemachine
    {
        public string Brand { get; set; }
        public int CupsPerBrew { get; set; }

        public Coffeemachine(string brand, int cupsPerBrew)
        {
            Brand = brand;
            CupsPerBrew = cupsPerBrew;
        }
        public void StartBrewing()
        {
            Console.WriteLine($"{Brand} coffeemachine starts brewing.");
        }
        public void StopBrewing()
        {
            Console.WriteLine($"{Brand} coffeemachine has stops brewing.");
        }
        public void PrintBrewingEnergy()
        {
            Console.WriteLine($"{Brand} coffeemachine uses 0.3 kWh per brew.");
        }
    }
}