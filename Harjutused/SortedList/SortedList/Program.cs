namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List");

            SortedList<int, string> numbrid = new SortedList<int, string>()
            {
                {3, "Three"  },
                {20, "Twenty" },
                {2, "Two" }
            };

            Console.WriteLine("Algne key value");

            foreach (KeyValuePair<int, string> kvp in numbrid)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            SortedList<string, string> words = new SortedList<string, string>()
            {
                {"Aabits", "Three"  },
                {"Canada", "Twenty" },
                {"Banaan", "Two" }
            };

            Console.WriteLine("--------------------");

            foreach (KeyValuePair<string, string> kvp in words)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("--------------");

            Console.WriteLine("Lisame kaks nime juurde");

            words.Add("New York", "USA");
            words.Add("Denmark", "Europe");

            foreach (KeyValuePair<string, string> kvp in words)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            }

            Console.WriteLine("---------------");

            numbrid.Add(6, "Six");
            numbrid.Add(2, "Two");
            numbrid.Add(4, "Four");

            Console.WriteLine("Kui oleme lisanud uued numbrid juurde, siis järjestab need ära");

           
        }
    }
}