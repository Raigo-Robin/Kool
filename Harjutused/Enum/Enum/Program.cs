namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            Console.WriteLine(WeekDays.Monday);

            int day = (int)WeekDays.Friday;

            Console.WriteLine(day);

            var weekDay = (WeekDays)2;

            Console.WriteLine(weekDay);

            Console.WriteLine("----------");

            int color = (int)Colors.Yellow;

            Console.WriteLine(color);
            
            
            ////Lubab ainult välja tuua väärtse mis on classis defineeritud
            ////See annab errorit
            //int colorWrongNr = (Colors)1;
            //Console.WriteLine(colorWrongNr);


        }

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

        }
        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 5,
            Yellow = 20,
            Black = 1,
            White = 9,
        }
    }
}