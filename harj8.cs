using System;

namespace Demo1
{
    class harj8
    {
        static void Main(string[] args)
        {
            const int MAX_TAULU = 3;
            int[] taulu = new int[MAX_TAULU] {0, 0, 0};
            int i, j, apu;

            for (i = 0; i < MAX_TAULU; i++)
            {
                Console.WriteLine("Anna Luku > ");
                taulu[i] = int.Parse(Console.ReadLine());
            }
                


            //vaihtolajittelu
            for (i = 0; i < MAX_TAULU - 1; i++)
            {
                for (j = i + 1; j < MAX_TAULU; j++)
                {
                    //cout << "i=" << i << " j=" << j << endl;
                    if (taulu[i] > taulu[j])
                    {
                        apu = taulu[i];
                        taulu[i] = taulu[j];
                        taulu[j] = apu;
                    }
                }
            }

         
            Console.WriteLine("\nSuurin luku on " + taulu[MAX_TAULU-1]);


            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}

