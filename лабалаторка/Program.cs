using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace лабалаторка
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            try { 
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========= MOVIE RENTAL SERVICE =========");
                Console.ResetColor();
            Console.WriteLine("1.Меню вибора фільмів");
            Console.WriteLine("2.Додати фільм");
            Console.WriteLine("3.Видалити фільм");
            Console.WriteLine("4.Інформація про Магазин");
            Console.WriteLine("вибери цифру щоб продовжити : ");
            int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Menu1();
                            break;
                        }
                    case 2:
                        {
                            AddMovie();
                            break;
                        }
                    case 3:
                        {
                            RemoveMovie();
                            break;
                        }
                    case 4:
                        {
                            Information();
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Main(args);
                
            }
        }
        static void Menu1()
        {
            try
            {
                int x;
                string a;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("1. Interstellar");
                Console.WriteLine("2. Inception");
                Console.WriteLine("3. Forrest Gump");
                Console.WriteLine("4. The Matrix");
                Console.Write("Choose a movie (1-4): ");
                Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Thank you for using our service! Enjoy your movie!");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error");
                Console.WriteLine("FormatException");
                Console.ResetColor();
            }
        }
        static void  AddMovie()
        {
            
            Console.WriteLine("Ви хочете додати фільм yes/no ");
            string a = Console.ReadLine().ToLower();
            if (a == "yes") 
            {
                Console.WriteLine("Який фільм порекомендуєте додати : ");
                string adedmovie = Console.ReadLine();
                Console.WriteLine("ви хочете додати  " + (adedmovie) +  " ви впевнені yes/no ");
                string assured = Console.ReadLine();
                if (assured == "yes") 
                {
                    Console.WriteLine(adedmovie);
                    Console.WriteLine("Щоб повернутися натисни {Enter}");
                    Console.ReadKey();
                    Console.Clear();
                    Menu1();
                }

            }
            else 
            {
                Menu1();
            }
            
        }
        static void RemoveMovie()
        {
            try { 
            Console.WriteLine("1. Interstellar");
            Console.WriteLine("2. Inception");
            Console.WriteLine("3. Forrest Gump");
            Console.WriteLine("4. The Matrix");
            Console.Write("Choose a movie (1-4): ");
            Console.WriteLine("Який Фільм видаляємо ? ");
            int remove = Convert.ToInt32(Console.ReadLine());
            switch (remove)
            {
                case 1: 
                {
                        Console.WriteLine("1. Видалено");
                        Console.WriteLine("2. Inception");
                        Console.WriteLine("3. Forrest Gump");
                        Console.WriteLine("4. The Matrix");
                        break;
                 }
                    case 2:
                    {
                        Console.WriteLine("1. Interstellar");
                        Console.WriteLine("2. Видалено");
                        Console.WriteLine("3. Forrest Gump");
                        Console.WriteLine("4. The Matrix");
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("1. Interstellar");
                        Console.WriteLine("2. Inception");
                        Console.WriteLine("3. Видалено");
                        Console.WriteLine("4. The Matrix");
                        break;
                    }
                    case 4:
                        {
                            Console.WriteLine("1. Interstellar");
                            Console.WriteLine("2. Inception");
                            Console.WriteLine("3. Forrest Gump");
                            Console.WriteLine("4. Видалено");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("немаэ такого значення");
                            break;
                            
                        }
                    }
            }
            catch (FormatException) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error");
                Console.WriteLine("FormatException");
                Console.ResetColor();
                RemoveMovie();
            }

        }
        static void Information()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("========== ІНФОРМАЦІЯ ПРО МАГАЗИН ==========");
            Console.WriteLine("Назва: Movie Rental Service");
            Console.WriteLine("Рік заснування: 2025");
            Console.WriteLine("Власник: Василь ");
            Console.WriteLine("Дякуємо, що користуєтесь нашим сервісом!");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("{Enter} щоб повернутися ");
            Console.ReadKey();
            Console.Clear();
            Main(new string[] { });
        }
    }
}
