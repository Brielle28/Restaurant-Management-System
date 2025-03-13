using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    public static class FoodQueryHandler
    {
        public static Dictionary<string, double> FoodArray = new FoodData()
        .MainCourseArray
        .Concat(new FoodData().DrinksArray)
        .Concat(new FoodData().DessertsArray)
        .Concat(new FoodData().AppetizerArray)
        .ToDictionary(k => k.Key, v => v.Value, StringComparer.OrdinalIgnoreCase);

        public static void SearchFoodByName()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Please enter the name of the food you want (e.g., 'Jollof Rice'):");
            Console.ResetColor();

            string foodByNameInput = Console.ReadLine();

            if (FoodArray.ContainsKey(foodByNameInput))
            {
                double price = FoodArray[foodByNameInput];
                Console.WriteLine($"{foodByNameInput} is available at ${price:F2}");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Please enter quantity: ");
                Console.ResetColor();
                string orderQuantityInput = Console.ReadLine();
                int userOrderQuantity;

                if (int.TryParse(orderQuantityInput, out userOrderQuantity) && userOrderQuantity > 0)
                {
                    double totalPrice = userOrderQuantity * price;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Order confirmation: {userOrderQuantity} plates of {foodByNameInput}. your order cost ${totalPrice:F2}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid quantity. Please enter a positive number.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Food is not available.");
                Console.ResetColor();
            }
        }


        public static void FoodByPriceRange()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Please enter the price amount of the food you want (e.g., '2.00'):");
            Console.ResetColor();
            string input = Console.ReadLine();
            double foodByAmountInput;
            if (double.TryParse(input, out foodByAmountInput))
            {
                var matchingFoods = FoodArray.Where(f => f.Value == foodByAmountInput);
                if (matchingFoods.Any())
                {
                    int i = 1;
                    foreach (var item in matchingFoods)
                    {
                        Console.WriteLine($"{i}. {item.Key} - ${item.Value:F2}");
                        i++;
                    }
                    ProcessOrder.processOrder(matchingFoods.ToDictionary(k => k.Key, v => v.Value));
                }
                else
                {
                    Console.WriteLine($"Sorry, we do not have any food priced at ${foodByAmountInput:F2}.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid input: please enter the correct amount next time");
                Console.ResetColor();
            }
        }

        public static void FoodByLowToHighPrice()
        {
            var sortedFoodByLowToHighPrice = FoodArray.OrderBy(f => f.Value);

            if (sortedFoodByLowToHighPrice.Any())
            {
                int i = 1;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Foods sorted by price (Low to High):");
                Console.ResetColor();
                foreach (var item in sortedFoodByLowToHighPrice)
                {
                    Console.WriteLine($"{i}. {item.Key} - ${item.Value:F2}");
                    i++;
                }
                ProcessOrder.processOrder(sortedFoodByLowToHighPrice.ToDictionary(k => k.Key, v => v.Value));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No foods available to sort.");
                Console.ResetColor();
            }
        }

        public static void FoodByHighToLowPrice()
        {
            var sortedFoodByHighToLowPrice = FoodArray.OrderByDescending(f => f.Value);

            if (sortedFoodByHighToLowPrice.Any())
            {
                int i = 1;
                Console.WriteLine("Foods sorted by price (High to Low):");
                foreach (var item in sortedFoodByHighToLowPrice)
                {
                    Console.WriteLine($"{i}. {item.Key} - ${item.Value:F2}");
                    i++;
                }
                ProcessOrder.processOrder(sortedFoodByHighToLowPrice.ToDictionary(k => k.Key, v => v.Value));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No foods available to sort.");
                Console.ResetColor();
            }
        }
    }
}
