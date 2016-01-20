using System;

namespace Demo1
{
    class harj10
    {
        static void Main(string[] args)
        {
            const int MAX_TAULU = 9;
            int[] taulu = new int[MAX_TAULU] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int i;


            for (i = 0; i < MAX_TAULU; i++)
            {
                if (taulu[i] % 2 == 0) Console.WriteLine("HEP");
                
            }








            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}

