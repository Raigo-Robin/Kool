namespace Tulemus
{
    internal class Program
    {
        float num, percent;
        static void Main(string[] args)
        {
            Console.WriteLine("Tulemus");

            Program program = new Program();
            program.Accept();
            program.Print();
            Console.ReadLine();

        }
        public void Accept()
        {
            Console.WriteLine("Sisesta hinne: ");
            num = float.Parse(Console.ReadLine());

        }

        public void Print()
        {
            percent = (float)num / 850 * 100;

            if (percent < 35)
            {
                Console.WriteLine("Sorry you failed! Better luck next time pal :). MARK:  "+ percent);
            }
            else if (percent > 35 && percent < 50)
            {
                Console.WriteLine("You got D. MARK: " + percent);
            }
            else if (percent > 50 && percent < 60)
            {
                Console.WriteLine("You got C. MARK: " +  percent);
            }
            else if (percent > 60 && percent < 75)
            {
                Console.WriteLine("You got C. MARK: " +  percent);
            }
            else
            {
                Console.WriteLine("SUPER! You got A. MARK: " +  percent);
            }
        }
    }
}