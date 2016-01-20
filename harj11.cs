using System;

namespace Demo1
{
    class harj11
    {
        static void Main(string[] args)
        {

            int kysy;
            int i, j;


                Console.WriteLine("Anna Luku > ");
                kysy = int.Parse(Console.ReadLine());




  
            for (i = 0; i < kysy; i++)
            {
                for (j = i + 1; j > 0; j--) Console.Write("*");

                Console.WriteLine();
            }



            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}

