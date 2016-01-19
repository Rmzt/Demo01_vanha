using System;

namespace Demo1
{
    class harj4
    {
        static void Main(string[] args)
        {
            int ika = 0;
    
            Console.WriteLine("Anna ikäsi: ");

            ika = int.Parse(Console.ReadLine());

            if (ika < 18) Console.WriteLine("Alaikäinen");
            else if (ika <= 65) Console.WriteLine("Aikuinen");
            else Console.WriteLine("Seniori");





            Console.WriteLine("\n\nAll done - exiting app");
        }
    }
}