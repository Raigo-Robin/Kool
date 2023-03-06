namespace Dictionary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");

            IDictionary<int, string> result = new Dictionary<int, string>();

            result.Add(1, "One");
            result.Add(2, "Two");
            result.Add(3, "Three");
            result.Add(4, "Four");

            foreach (KeyValuePair<int,string >kvp in result)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

          
            
            Console.WriteLine("------------------------------");
            var cities = new Dictionary<string, string>()
            {
                { "EST", "Tallinn, Tartu, Pärnu" },
                { "LAT", "Riga, Daugvapils, Jurmala" },
                { "FIN", "Helsinki, Turu, Tampere" },
            };
            int i = 0;
            foreach (var kvp in cities)
            {
                i++;
                Console.WriteLine("Key: {0}, Value: {1}, {2}", kvp.Key, kvp.Value, i );
            }

            Console.WriteLine("------------------------------");
            var linnad = new Dictionary<string, string>()
            {
                { "EST", "Tallinn, Tartu, Pärnu" },
                { "LAT", "Riga, Daugvapils, Jurmala" },
                { "FIN", "Helsinki, Turu, Tampere" }
            };

            linnad["EST"] = "Võru, Paldiski";
            linnad["FIN"] = "Tampere, Porvo";

            foreach (var kvp in linnad)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("------------------------------");

            linnad.Remove("EST");
            Console.WriteLine("Total Elements: {0}", linnad.Count);

            Console.WriteLine("------------------------------");

            linnad.Clear();
            Console.WriteLine("Total Elements: {0}", linnad.Count);

            Console.WriteLine("------------------------------");




        }
    }
}