using System;

namespace Demo1
{
    class harj5
    {
        static void Main(string[] args)
        {
            int aika = 0, tunti = 0, minuutti = 0;

            Console.WriteLine("Anna sekunnit > ");

            aika = int.Parse(Console.ReadLine());

            while (aika >= 3600)
            {
                aika -= 3600;
                tunti++;
            }
            while (aika >= 60)
            {
                aika -= 60;
                minuutti++;
            }


            Console.WriteLine(tunti + " tuntia " + minuutti + " minuuttia " + aika + " sekunttia.");


            /*if (ika < 18) Console.WriteLine("Alaikäinen");
            else if (ika <= 65) Console.WriteLine("Aikuinen");
            else Console.WriteLine("Seniori");*/





            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}