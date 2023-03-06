namespace MethodCall3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näita maksimaalset numbrit");

            int a = 700;
            int b = 400;
            int ret;

            Program p = new Program();
            ret = p.DisplayMax(a, b);
            Console.WriteLine("Maksimaalne väärtus on: {0}", ret);
            Console.ReadLine();

        }


        public int DisplayMax(int num1, int num2)
        {
            int result;
            if (num1 > num2) 
            {
                result = num1;
            }
            else
            {
                result = num2;
                
            }
            return result;
        }
    }
}