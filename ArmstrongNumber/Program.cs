using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int zacetnoStevilo;
            int ostanek;
            int sestevek = 0;
            int zacasnoStevilo;

            Console.WriteLine("Kaj je Armstrongovo število?");
            Console.WriteLine("Armstrongovo število (Michael F. Armstrong) je število, ki je vsota lastnih števk, vsaka dvignjena na stopnjo števila števk. Več info: https://www.deimel.org/rec_math/DI_6.htm \n");

            Console.Write("Vnesi število: ");
            zacetnoStevilo = int.Parse(Console.ReadLine());

            int numDolzina = zacetnoStevilo.ToString().Length;

            zacasnoStevilo = zacetnoStevilo;

            Console.WriteLine("\nZačetno število je: " + zacetnoStevilo);
            Console.WriteLine("Začasno število je: " + zacasnoStevilo);
            Console.WriteLine("Seštevek števila je: " + sestevek);

            while (zacetnoStevilo > 0)
            {
                ostanek = zacetnoStevilo % 10;
                Console.WriteLine("\nŠtevilo, ki ostane je: " + ostanek);
                sestevek = (int)(sestevek + Math.Pow(ostanek, numDolzina));
                Console.WriteLine("Seštevek enomestnega števila je: " + sestevek);
                zacetnoStevilo = zacetnoStevilo / 10;
                Console.WriteLine("Začetno število je: " + zacetnoStevilo);
                Console.WriteLine("");
            }

            if (zacasnoStevilo == sestevek)
            {
                Console.Write("\nVneseno število je Armstrongovo število!\n");
            } else
            {
                Console.Write("Vneseno število ni Armstrongovo število!\n");
                Console.WriteLine("Primer Armstrongovega števila: 153 (1*1*1) + (5*5*5) + (3*3*3), 370 (3*3*3) + (7*7*7) + (0*0*0),...");
            }
            Console.Write("\n");
        }
    }
}
