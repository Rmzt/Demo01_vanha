using System;

namespace Demo1
{
    class harj6
    {
        static void Main(string[] args)
        {
            float matka;

            Console.WriteLine("Anna matka > ");

            matka = float.Parse(Console.ReadLine());

      

            Console.WriteLine("Bensaa kuluu " + (matka/100*7.02) + " litraa, kustannus " + (matka/100*7.02*1.595) + " euroa.");

            // jollakin tapaa voisi rajoittaa desimaalien määrää





            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}