namespace Struct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            Coordinate point = new Coordinate(11, 15);

            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("-------------------");

            Coordinate points;
            Console.WriteLine(point.X);

            Console.WriteLine("-------------------");
            points.X = 5;
            points.Y = 10;
            Console.WriteLine(points.X);
            Console.WriteLine(points.Y);
            Console.WriteLine("---------------------");
            StringAndInt stringInt = new StringAndInt("asd", 1);

            Console.WriteLine(stringInt.Name);
            Console.WriteLine(stringInt.Index);

            Console.WriteLine("----------------");

            InsertedInt insertedInt = new();

            Console.WriteLine(insertedInt.PostalCode);
            Console.WriteLine(insertedInt.City);





        }
    }

    //structi eelis seisneb selles, et saan erinevaid andmetüüpe sisse panna
    
    struct Coordinate
    {
        public int X;
        public int Y;

        //Konstruktor
        public Coordinate (int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct StringAndInt
    {
        public string Name;
        public int Index;
        public StringAndInt(string name, int index)
        {
            Name = name;
            Index = index;
        }
    }

    struct InsertedInt
    {
        public int PostalCode = 10;
        public string City = "Tallinn";

        public InsertedInt()
        {
            PostalCode = 45204;
            City = "Vohnja";

            
        }
    }
}