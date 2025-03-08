using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    public class ProcessOrder
    {

        public static void Process0rder(string[] foodItems)
        {
            string userInput = Console.ReadLine();
            int order;

            if (int.TryParse(userInput, out order))
            {
                string OrderFoodType;

                if (order >= 1 && order <= foodItems.Length)
                {
                    OrderFoodType = foodItems[order - 1];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice.");
                    Console.ResetColor();
                    return;
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Please enter quantity:");
                Console.ResetColor();
                string orderQuantityInput = Console.ReadLine();
                int UserOrderQuantity;

                if (int.TryParse(orderQuantityInput, out UserOrderQuantity))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Order confirmation: You have ordered {0} quantity of {1}", UserOrderQuantity, OrderFoodType);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid quantity.");
                    Console.ResetColor();
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
