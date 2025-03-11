using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_Management_System
{
    public class ProcessOrder
    {
        public static void processOrder(Dictionary<string, double> foodItems)
        {
            string userInput = Console.ReadLine();
            int order;

            if (int.TryParse(userInput, out order) && order >= 1 && order <= foodItems.Count())
            {
                var foodList = foodItems.ToList();
                var selectedFood = foodList[order - 1];

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Please enter quantity: ");
                Console.ResetColor();
                string orderQuantityInput = Console.ReadLine();
                int userOrderQuantity;

                if (int.TryParse(orderQuantityInput, out userOrderQuantity) && userOrderQuantity > 0)
                {
                    double totalPrice = userOrderQuantity * selectedFood.Value;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Order confirmation: {userOrderQuantity} plates of {selectedFood.Key}. your order cost ${totalPrice:F2}");
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice. Please select a valid food item number.");
                Console.ResetColor();
            }
        }
    }
}
