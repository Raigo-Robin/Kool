namespace MatemaatilineKoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemaatiline Koer");

            Console.WriteLine("Palun sisesta esimene arv");
            float firstNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisesta tehe: ");
            string operation = Console.ReadLine();

            Console.WriteLine("Palun sisesta teine arv");
            float secondNr = int.Parse(Console.ReadLine());



            try
            {
                switch (operation)
                {
                    case "+":
                        float resultAdd = firstNr + secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd);
                        break;


                    case "-":
                        float resultSubtract = firstNr - secondNr;
                        Console.WriteLine("Kahe numbri lahutamisel on vastus: " + resultSubtract);
                        break;

                    case "*":
                        float resultMultiply = firstNr * secondNr;
                        Console.WriteLine("Kahe numbri korrutamisel on vastus: " + resultMultiply);
                        break;

                    case "/":
                        float resultDivide = firstNr / secondNr;
                        Console.WriteLine("Kahe numbri jagamisel on vastus: " + resultDivide);
                        break;  
                    
                    default:
                        break;

                       
                }
            }
            catch (FormatException)//numbrilise väärtuse kontroll
            {
                Console.WriteLine("Vale numbri formaat!");
                //throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR!!!!");
            }
        }
    }
}
