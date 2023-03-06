namespace MethodCall
{
    internal class Program
    {

        string name, city;
        int age; 
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi esile kutsumine");
            
            Program Program = new();
            Program.AcceptDetails();
            Program.PrintDetails();
            Console.ReadLine();
        }

        public void AcceptDetails()
        {
            Console.WriteLine("\nSisesta enda nimi: \t");
            name = Console.ReadLine();
           
            Console.WriteLine("\nSisesta kodulinna nimi: \t");
            city = Console.ReadLine();
            
            Console.WriteLine("\nSisesta enda vanus: \t");
            age = Convert.ToInt32(Console.ReadLine());

        }

        public void PrintDetails()
        {
            Console.Write("\n\n==================");
            Console.Write("\nName:\t" + name);
            Console.Write("\nCity:\t" + city);
            Console.Write("\nAge:\t" + age);
            Console.Write("\n\n==================");


        }
    }
}