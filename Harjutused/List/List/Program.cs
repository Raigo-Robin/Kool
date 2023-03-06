namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ"); //Language Inquery
            IList<Person> Person = new List<Person>()
            {
                new Person() {Id = 1, Name = "Juku", Age = 10 },
                new Person() {Id = 2, Name = "Juhan", Age = 11 },
                new Person() {Id = 3, Name = "Maali", Age = 9 },
                new Person() {Id = 4, Name = "Sten", Age = 10},
            };

            var persons = from s in Person
                          select new
                          {
                              Id = s.Id,
                              Name = s.Name,
                              Age = s.Age
                          };

            foreach (var per in persons)
            {
                Console.WriteLine("Id on: " + per.Id + " ja nimi on: " + per.Name);
            }

            Console.WriteLine("LINQ SELECT!");

            var result = Person
                //.Where(p => p.Id == 1) //Toob välja selle Id-ga väärtuse
                //.Where(y => y.Id == 1|| y.Age == 9) näen ainlt tulemust mis sisaldavad id 1 ja inimest kellel on vanus 9
                .OrderBy(y => y.Name) // Järjestab isikud nime järgi ära
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age,
                    Id = x.Id

                });


            foreach (var per in result)
            {
                Console.WriteLine("Id on: " + per.Id + " ja nimi on: " + per.Name);
            }

            Console.WriteLine("Kasutame GroupBy-d sorteerimiseks");

            var groupBy = Person
                .GroupBy(x => x.Age); //kuvab gruppide kaupa ja antud juhul paneb vanused gruppidesse e tulemus on kolm rida andemid kuna kaks vanus ühtivad 

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}",item.Key);
            }


        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


    }
}