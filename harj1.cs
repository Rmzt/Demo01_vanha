using System;

namespace Demo1
{
    class harj1
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {

                number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;

                    case 2:
                        Console.WriteLine("Two");
                        break;

                    case 3:
                        Console.WriteLine("Three");
                        break;

                    default:
                        Console.WriteLine("Unknown number");
                        break;
                }

            } while (number != 0);

            Console.WriteLine("All done - exiting app");
        }
    }
}