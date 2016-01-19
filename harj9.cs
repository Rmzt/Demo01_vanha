using System;

namespace Demo1
{
    class harj9
    {
        static void Main(string[] args)
        {
            int luku, summa = 0;

            do
            {
                Console.WriteLine("Anna Luku > ");
                luku = int.Parse(Console.ReadLine());
                summa += luku;
            } while (luku != 0);

            Console.WriteLine("Lukujen summa on " + summa);





            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}