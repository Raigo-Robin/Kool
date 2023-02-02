using System.Diagnostics;

namespace TEST___Raigo_Robin_Anni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koosta neli funktsiooni, millest igaüks arvutab ja 
            //väljastab ühe geomeetrilise kujundi(ruut, 
            //ring või teemant, ristkylik, kolmnurk) 
            //kujundi "*" sümbolina(vastavalt võimalusele 
            //arvutab ja väljastab viimaks ka ümbermõõdu, 
            //pindala jne).Loo programm, mis küsib kasutajalt 
            //kujundi tüüpi sõna valikuna, kujundi andmeid
            //(vastavalt vajadusele külje pikkust, raadiust vms).
            //NB! Teemanti puhul arvutage ringi ümbermõõt ja pindala.

            Console.WriteLine("Sisesta kujundi number: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");



            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    Ruut();
                    break;

                case "2":
                    Teemant();
                    break;

                case "3":
                    Ristkülik();
                    break;
                case "4":
                    kolmnurk();
                    break;


                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }


        private static void Ruut()
        {

            Console.Write("Palun sisesta ruudu külje pikkus: ");
            int ruudukülg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int row = 1; row < ruudukülg; row++)
            {
                for (int column = 1; column < ruudukülg; column++)
                {
                    if (column <= row)
                        Console.Write("*");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            int ruudupindala = ruudukülg * ruudukülg;
            int ruuduümbermõõt = ruudukülg * 4;
            Console.WriteLine("Ruudu ümbermõõt on: {0}", ruuduümbermõõt);
            Console.WriteLine("Ruudu pindala on: {0}", ruudupindala);


        }
        private static void Teemant()
        {
            Console.Write("Sisestage teemandi suurus: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int j;

            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("Kuna teemantil pole täpset arvutuskäiku, siis lähima tulemuse saab ringi valemiga. Palun sisesta ringi raadius: ");
            int raadius = Convert.ToInt32(Console.ReadLine());
            double ringiümbermõõt = 2 * 3.14159265358979 * raadius;
            double ringipindala = raadius * raadius * 3.14159265358979;

            Console.WriteLine("Ringi ümbermõõt on: {0}", ringiümbermõõt);
            Console.WriteLine("Ringi pindala on: {0}", ringipindala);

        }
        private static void Ristkülik()
        {
            Console.Write("Palun sisesta esimese külje pikkus: ");
            int esimenekülg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Palun sisesta teise külje pikkus: ");
            int teinekülg = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < esimenekülg; row++)
            {
                for (int column = 0; column < teinekülg; column++)
                {
                    if (column <= row)
                        Console.Write("*");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }

            int ristkülikuümbermõõt = 2 * esimenekülg + teinekülg;
            int ristkülikupindala = esimenekülg * teinekülg;

            Console.WriteLine("Ristküliku ümbermõõt on: {0}", ristkülikuümbermõõt);
            Console.WriteLine("Ristküliku pindala on: {0}", ristkülikupindala);
        }

        private static void kolmnurk()      
        {
           
            
            Console.WriteLine("Palun sisesta kolmnurga suurus ühikuna: ");
            int suurus = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Palun sisesta kõrgus: ");
            int kõrgus = Convert.ToInt32(Console.ReadLine());

            int j;

            for (int i = 0; i <= suurus; i++)
            {
                for (j = 1; j <= suurus - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }


            int kolmnurgapindala = suurus * kõrgus;
            int kolmnurgaümbermõõt = suurus + suurus + suurus;

            Console.WriteLine("Kolmnurga ümbermõõt on: {0} ", kolmnurgaümbermõõt);
            Console.WriteLine("Kolmnurga pindala on: {0} ", kolmnurgapindala);

            }
        }
    }
