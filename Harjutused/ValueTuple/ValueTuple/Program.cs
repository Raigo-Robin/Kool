namespace ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Tuple");

            ValueTuple<int, string, string> person1 = (1, "Onu", "Jaagup");
            Console.WriteLine(person1.Item1);
            Console.WriteLine(person1.Item2);
            Console.WriteLine(person1.Item3);

            Console.WriteLine("-----------------------");

            (int, string, string) person2 = (1, "Tädi", "Pedro");
            Console.WriteLine(person2.Item1);
            Console.WriteLine(person2.Item2);
            Console.WriteLine(person2.Item3);


            Console.WriteLine("-----------------------");

            (int id, string firstName, string lastName) person3 = (1, "Vanaema", "Maie");
            Console.WriteLine(person3.id);
            Console.WriteLine(person3.firstName);
            Console.WriteLine(person3.lastName);

            Console.WriteLine("-----------------------");

            (int id1, string firstName2, string lastName3) person4 = (PersonId: 1, FName: "Tagu", LName3: "Ots");
            Console.WriteLine(person4.id1);
            Console.WriteLine(person4.firstName2);
            Console.WriteLine(person4.lastName3);

            Console.WriteLine("-----------------------");
            //Sellist varianti ei saa teha kuna sulgudes olev järjestus on vale
            //(string, string, int) person5 = ((PersonId: 1, FName: "Tagu", LName3: "Ots");

            var result = GetPerson();

            Console.WriteLine("{0}, {1}, {2}", result.Item1, result.Item2, result.Item3);

            Console.WriteLine("-----------------------");

            var result1 = GetPerson2();
            Console.WriteLine("{0}, {1}, {2}", result1.id, result1.firstName, result1.lastName);


        }
        static (int, string, string) GetPerson()
        {
            return (1, "Kaja", "Kallas");
        }

        static (int id, string firstName, string lastName) GetPerson2()
            {
            return (id: 1, firstName: "Peeter", lastName: "Võsa");
            }

           
    }
}