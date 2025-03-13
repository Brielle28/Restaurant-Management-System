using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class OrderOptions
    {
        public static void orderOptions()
        {
            bool isOrdering = true;
            while (isOrdering)
            {

                Dictionary<int, string> Options = new Dictionary<int, string>
                {
                    {1, "Search for a Food by Name" },
                    {2, "Search for Foods at a specific Price" },
                    {3, "Sort Foods by Price (Low to High)" },
                    {4, "Sort Foods by Price (High to Low)" },
                    {5, "Browse the Full Menu" },
                    {6, "Home" }
                };

                foreach (KeyValuePair<int, string> kv in Options)
                {
                    Console.WriteLine($"{kv.Key}. {kv.Value}");
                }

                string orderInput = Console.ReadLine();
                int orderChoice;
                if (int.TryParse(orderInput, out orderChoice))
                {
                    switch (orderChoice)
                    {
                        case 1:
                            FoodQueryHandler.SearchFoodByName();
                            break;
                        case 2:
                            FoodQueryHandler.FoodByPriceRange();
                            break;
                        case 3:
                            FoodQueryHandler.FoodByLowToHighPrice();
                            break;
                        case 4:
                            FoodQueryHandler.FoodByHighToLowPrice();
                            break;
                        case 5:
                            OrderHandler.StartOrdering();
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Exiting and returnng to the Home Page");
                            Console.ResetColor();
                            isOrdering = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ResetColor();
                }

            }
        }
    }

}

