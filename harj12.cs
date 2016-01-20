using System;

namespace Demo1
{
    class harj12
    {
        static void Main(string[] args)
        {
            const int MAX_TAULU = 5;
            int[] taulu = new int[MAX_TAULU] { 0, 0, 0, 0, 0 };
            int i;

            for (i = 0; i < MAX_TAULU; i++)
            {
                Console.WriteLine("Anna Luku > ");
                taulu[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Luvut ovat");

            for (i = MAX_TAULU; i > 0; i--)
            {
                Console.Write(" " + taulu[i-1]);
            }


            


            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}

