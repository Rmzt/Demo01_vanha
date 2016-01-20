using System;

namespace Demo1
{
    class harj14
    {
        static void Main(string[] args)
        {
            const int MAX_TAULU = 6;
            int[] taulu = new int[MAX_TAULU] { 0, 0, 0, 0, 0, 0 };
            int i, j, apu = 0;

            do
            {
                Console.Write("Anna arvosana > ");
                apu = int.Parse(Console.ReadLine());

                switch (apu) {
                    case 0: taulu[0]++; break;
                    case 1: taulu[1]++; break;
                    case 2: taulu[2]++; break;
                    case 3: taulu[3]++; break;
                    case 4: taulu[4]++; break;
                    case 5: taulu[5]++; break;
                }

            } while (apu >= 0);

            Console.WriteLine("Arvosanat:");
            for (j = 0; j < MAX_TAULU; j++)
            {
                Console.Write(j + ":");
                for (i = 0; i < taulu[j]; i++) Console.Write("*");
                Console.WriteLine();
            }
        


            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}

