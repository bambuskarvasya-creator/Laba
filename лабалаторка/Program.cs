using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабалаторка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            string a;
            Console.WriteLine("MOVIE RENTAL SERVICE");
            Console.WriteLine("Available movies:");
            Console.WriteLine("1. Interstellar");
            Console.WriteLine("2. Inception");
            Console.WriteLine("3. Forrest Gump");
            Console.WriteLine("4. The Matrix");
            Console.Write("Choose a movie (1-4): ");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("You chose Interstellar");
                Console.WriteLine("Are you sure? (yes/no): ");
                a = Console.ReadLine().ToLower();
                if (a == "yes")
                {
                    Console.WriteLine("Service price: $20");
                }
                if (a == "no")
                {
                    Console.WriteLine("Select the next movie:");
                    x = byte.Parse(Console.ReadLine());
                }
            }

            if (x == 2)
            {
                Console.WriteLine("You chose  Inception ");
                Console.WriteLine("Are you sure? (yes/no):  ");
                a = Console.ReadLine().ToLower();
                if (a == "yes")
                {
                    Console.WriteLine("Service price: $23");

                }
                if (a == "no")
                {
                    Console.WriteLine("Select the next movie:");
                    x = int.Parse(Console.ReadLine());
                }
            }

            if (x == 3)
            {
                Console.WriteLine("You chose Forrest Gump  ");
                Console.WriteLine("Are you sure? (yes/no): ");
                a = Console.ReadLine().ToLower();
                if (a == "yes")
                {
                    Console.WriteLine("Service price: $15");

                }
                if (a == "no")
                {
                    Console.WriteLine("Select the next movie:");
                    x = int.Parse(Console.ReadLine());
                }
            }

            if (x == 4)
            {
                Console.WriteLine("You chose The Matrix");
                Console.WriteLine("Are you sure? (yes/no):  ");
                a = Console.ReadLine().ToLower();
                if (a == "yes")
                {
                    Console.WriteLine("Service price: $12");

                }
                if (a == "no")
                {
                    Console.WriteLine("Select the next movie:");
                    x = int.Parse(Console.ReadLine());
                }
            }

            else if (x > 4 || x == 0)
            {
                x = 4;
                Console.WriteLine("You chose The Matrix ");
                Console.WriteLine("Are you sure? (yes/no):  ");
                a = Console.ReadLine().ToLower();
                if (a == "yes")
                {
                    Console.WriteLine("Service price: 5$ ");

                }
                if (a == "no")
                {
                    Console.WriteLine("Select the next movie:");
                    x = byte.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using our service! Enjoy your movie!");
        }
    }
}
