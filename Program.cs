namespace APIConnectionExample
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper.InitializeClient();

            var sunInfo = await SunProcessor.LoadSunInfo(DateTime.Now);
            Console.WriteLine($"Sunrise in Moscow today is at {sunInfo.Sunrise.ToLocalTime().ToShortTimeString()}");
            Console.WriteLine($"Sunset in Moscow today is at {sunInfo.Sunset.ToLocalTime().ToShortTimeString()}\n");


            sunInfo = await SunProcessor.LoadSunInfo(DateTime.Parse("2022-06-14"));
            Console.WriteLine($"The earliest sunrise in Moscow was at {sunInfo.Sunrise.ToLocalTime().ToShortTimeString()}\n");


            sunInfo = await SunProcessor.LoadSunInfo(DateTime.Parse("2022-06-25"));
            Console.WriteLine($"The latest sunset in Moscow was at {sunInfo.Sunset.ToLocalTime().ToShortTimeString()}\n");
        }
    }
}