using System;

namespace Demo1
{
    class harj2
    {
        static void Main(string[] args)
        {
            //RunTask2();
            int points = 0;
            do
            {
                Console.WriteLine("Please enter amount of points");

                points = int.Parse(Console.ReadLine());


                switch (points)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("Grade is 0");
                        break;

                    case 2:
                    case 3:
                        Console.WriteLine("Grade is 1");
                        break;

                    case 4:
                    case 5:
                        Console.WriteLine("Grade is 2");
                        break;

                    case 6:
                    case 7:
                        Console.WriteLine("Grade is 3");
                        break;

                    case 8:
                    case 9:
                        Console.WriteLine("Grade is 4");
                        break;

                    case 10:
                    case 11:
                    case 12:
                        Console.WriteLine("Grade is 5");
                        break;

                    default:
                        Console.WriteLine("Unknown number of points");
                        break;
                }
              

            } while (points != 0);

            Console.WriteLine("All done - exiting app");
        }

       /* static void RunTask2()
        {
            asfkkf
        }
        */
    }
}