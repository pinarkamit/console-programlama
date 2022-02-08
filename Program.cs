namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

            byte havaDurumu = 26;
            string isim = "Pınar";
            double KDV = 0.18D;
            float sicaklik = 25.48F;       
            decimal uzaklık = 0.145M;
            string uzaklik = "20";
            int uzaklikInt = int.Parse(uzaklik);
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}