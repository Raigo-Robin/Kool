namespace Swtich_Harjutus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto mudeli valik \n");
            Console.WriteLine("Millist tüüpi autot soovite? Palun valige number. \n 1. Sedan \n 2. Hatchback \n 3. SUV");
            int valik = int.Parse(Console.ReadLine());
            //Uus list
            var mudel1 = new List<string>() { "BMW M3", "BMW M4", "Porsche Panamera Turbo S", "Subrau WRX" };
            var mudel2 = new List<string>() { "Volkswagen Golf R", "Honda Civic Type R", "Ford Focus ST" };
            var mudel3 = new List<string>() { "Porsche Macan GTS", "Audi SQ7", "BMW X3" };
            
            
            
            //Teen uue variable mis valib random stringi
            var rnd = new Random(); 

            switch (valik) 
            {

                case 1:
                    //Nüüd kasutan seda Random variable listis ja prindid
                    Console.WriteLine("Sulle sobiks: " + mudel1[rnd.Next(0, mudel1.Count)]);
                    break;  
               
                case 2: Console.WriteLine("Sulle sobiks: " + mudel2[rnd.Next(0, mudel2.Count)]);
                    break;
                
                case 3: Console.WriteLine("Sulle sobiks: " + mudel3[rnd.Next(0,mudel3.Count)]);
                    break;

                default:
                    Console.WriteLine("ERROR!");
                    break;
            
            }
        }
    }
}