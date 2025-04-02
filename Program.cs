namespace WeatherStationSimulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter tge number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = {"Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-20, 55);
                weatherConditions[i] = conditions[random.Next(0, 4)];
            }
        }
    }
}
