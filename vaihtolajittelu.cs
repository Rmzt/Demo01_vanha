using System;


namespace Demo1
{
    class vaihtolajittelu
    {
        static void Main(string[] args)
        {
            const int MAX_TAULU = 10;
            int[] taulu = new int[MAX_TAULU] {3, 2, 4, 1, 6, 5, 8, 0, 9, 7};
            int ind, i, j, apu;

            //tulostus
            for (ind = 0; ind < MAX_TAULU; ind++)
            {
                Console.WriteLine("taulu[" + ind + "]: " + taulu[ind] + "\n");
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

            //tulostus
            Console.WriteLine("\nTaulukko suuruusjarjestyksessa:\n\n");
            for (ind = 0; ind < MAX_TAULU; ind++)
            {
                Console.WriteLine("taulu[" + ind + "]: " + taulu[ind] + "\n");
            }


            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}