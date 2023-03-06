namespace Tuple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuple");

            var humans = Tuple.Create(1, "Jaan", "Tallinn");
            Console.WriteLine(humans.Item1);
            Console.WriteLine(humans.Item2);
            Console.WriteLine(humans.Item3);

            Console.WriteLine("------------------------");

            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);

            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            Console.WriteLine(numbers.Rest.Item1);

            Console.WriteLine("------------------------");

            var numbrid = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9 ,10, 11, 12, 13));

            Console.WriteLine(numbrid.Item1);
            Console.WriteLine(numbrid.Item7);
            Console.WriteLine(numbrid.Rest.Item1);
            Console.WriteLine(numbrid.Rest.Item1.Item1);
            Console.WriteLine(numbrid.Rest.Item1.Item2);

            Console.WriteLine("------------------------");

            DisplayTuple(humans);

            Console.WriteLine("------------------------");
            var person = GetHuman();
            Console.WriteLine(person);
        }

        //Tuple väärtuse saamine läbi meetodi parameetrite
        static void DisplayTuple(Tuple<int, string, string> humans )
        {
            Console.WriteLine($"Id = {humans.Item1}");
            Console.WriteLine($"First name = {humans.Item2}");
            Console.WriteLine($"Last name = {humans.Item3}");
        }

        //tuple, kui return tüüp
        static Tuple<int, string, string> GetHuman()
        {
            return Tuple.Create(1, "Onu", "Jaagup");
        }

    }
}