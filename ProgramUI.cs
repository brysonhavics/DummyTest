using KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Console
{
    public class ProgramUI
    {
        private readonly MenuRepository menuRepository = new MenuRepository();
        public void Run()
        {
            SeedContent();

            Menu();
        }

        public void SeedContent()
        {
            Console.WriteLine("Seeding....");


            //List<string> m1Ingrediants = new List<string> { "Bun", "Patty", "Cheese", "Sauce" };
            Menu m1 = new Menu(1, "Burger", "A juicy burger baby!", new List<string> { "Bun", "Patty", "Sauce" }, 8.99);
            Menu m2 = new Menu(2, "CheeseBurger", "A juicy cheeseburger baby!", new List<string> { "Bun", "Patty", "Cheese", "Sauce" }, 9.99);
            Menu m3 = new Menu(3, "BaconBurger", "A juicy baconburger baby!", new List<string> { "Bun", "Patty", "Cheese","Bacon", "Sauce" }, 10.99);
            Menu m4 = new Menu(4, "WHOPPER", "Nothing else to be said", new List<string> { "2 Buns", "2 Patties", "2 Cheese","2 Bacon", "2 Sauce" }, 12.99);


            menuRepository.AddItemToMenu(m1);
            menuRepository.AddItemToMenu(m2);
            menuRepository.AddItemToMenu(m3);
            menuRepository.AddItemToMenu(m4);
        }

        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                // \n = new line = CR + LF
                // CR = Carriage Return
                // LF = Line Feed
                Console.WriteLine("Menu:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Show all content
                        DisplayAllContents();
                        break;
                    case "2":
                        // Find by title
                        GetContentByTitle();
                        break;
                    case "3":
                        // Add new content
                        AddNewContent();
                        break;
                    case "4":
                        // Remove content
                        RemoveContent();
                        break;
                    case "exit":
                    case "EXIT":
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Goodbye!");
            Thread.Sleep(2000);

            // returns a ConsoleKeyInfo:
            // var key = Console.ReadKey();
            // returns a string:
            // Console.ReadLine();
        }
    }
    }
}
