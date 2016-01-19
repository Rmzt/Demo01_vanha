using System;

namespace Demo1
{
    class harj7
    {
        static void Main(string[] args)
        {
            int vuosi = 0;

            Console.WriteLine("Anna vuosi > ");

            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0)
            {
                if(vuosi % 100 == 0 && vuosi % 400 != 0) Console.WriteLine("Vuosi EI ole karkausvuosi.");
                else Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else Console.WriteLine("Vuosi EI ole karkausvuosi.");





            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}