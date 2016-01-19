using System;

namespace Demo1
{
    class harj3
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
    
            Console.WriteLine("Anna luku1");

            luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku2");

            luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku3");

            luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summa " + (luku1+luku2+luku3) + " ja keskiarvo " + (luku1+luku2+luku3)/3);



            Console.WriteLine("\n\nAll done - exiting app\n\n");
        }
    }
}