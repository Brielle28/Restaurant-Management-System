using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    public static class OrderHandler
    {
        public static void StartOrdering()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" which kind of food would you like");
            Console.ResetColor();
            bool Ordering = true;

            while (Ordering)
            {
                //listing orders caterogry
                var OrderCatergory = new Dictionary<int, string>
                {
                    { 1, "Main Foods" },
                    { 2, "Desserts"},
                    { 3, "Appetizer" },
                    { 4, "Drinks" },
                    {5, "exit" }
                };
                foreach (KeyValuePair <int, string> KV in OrderCatergory)
                {
                    Console.WriteLine($"{KV.Key}. {KV.Value}");
                }
                int UserOrderChoice;
                string orderInput = Console.ReadLine();
                UserOrderChoice = Int32.Parse(orderInput);

                // switch case
                switch (UserOrderChoice)
                {
                    case 1:
                        MainFood mainCourse = new MainFood();
                        mainCourse.DisplayFoods();
                        break;
                    case 2:
                        Desserts dessert = new Desserts();
                        dessert.DisplayFoods();
                        break;
                    case 3:
                        Appetizer appetizer = new Appetizer();
                        appetizer.DisplayFoods();
                        break;
                    case 4:
                        Drinks drinks = new Drinks();
                        drinks.DisplayFoods();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Exiting.....");
                        Console.ResetColor();
                        Ordering = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice,try again");
                        Console.ResetColor();
                        break;

                }


            }

        }
    }
}
