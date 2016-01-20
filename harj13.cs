using System;

namespace Demo1
{
    class harj8
    {
        static void Main(string[] args)
        {
            const int MAX_TAULU = 5;
            int[] taulu = new int[MAX_TAULU] { 0, 0, 0, 0, 0 };
            int i, j, apu, summa = 0;

            for (i = 0; i < MAX_TAULU; i++)
            {
                Console.Write("Anna Luku > ");
                taulu[i] = int.Parse(Console.ReadLine());
            }



            //vaihtolajittelu
            for (i = 0; i < MAX_TAULU - 1; i++)
            {
                for (j = i + 1; j < MAX_TAULU; j++)
                {
                    if (taulu[i] > taulu[j])
                    {
                        apu = taulu[i];
                        taulu[i] = taulu[j];
                        taulu[j] = apu;
                    }
                }
            }

            //lisätään kaikki paitsi pienin ja suurin summaan
            for (i = 1; i < MAX_TAULU - 1; i++)
            {
                summa += taulu[i];
            }

            Console.WriteLine("Kokonaispisteet ovat " + summa);


            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}

