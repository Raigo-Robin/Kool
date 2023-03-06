namespace Stopwatch_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch 2.0 ULTRA EDITION XS MAXIMUM POWAAAAA");
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.WriteLine(i);
            }
            stopwatch.Stop();

            Console.WriteLine("You are about to feel the powaaaaaaaaa: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

    }
}