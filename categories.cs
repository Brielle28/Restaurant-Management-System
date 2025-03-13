using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    public class FoodData
    {

        public Dictionary<string, double> MainCourseArray = new Dictionary<string, double>
        {
            {"Jollof Rice", 5.00},
            {"Fried Rice", 6.50},
            {"Spaghetti", 8.50 },
            { "Yam and Egg Sauce" ,10.50 }
        };

        public Dictionary<string, double> DrinksArray = new Dictionary<string, double>
        {
            { "Coke", 2.00 },
            { "Fanta", 2.50 },
            { "Cocktail", 1.50 },
            { "Energy Drink", 3.50 }
        };
        public Dictionary<string, double> AppetizerArray = new Dictionary<string, double>
        {
            { "Pizza", 1.50 },
            { "Donuts", 3.50 },
            { "Beef Wraps", 2.50 },
            { "Chips", 2.00 }
        };

        public Dictionary<string, double> DessertsArray = new Dictionary<string, double>
        {
            { "Dessert_1", 2.00 },
            { "Dessert_2", 2.00 },
            { "Dessert_3", 2.00},
            { "Dessert_4", 2.00 }
        };

        // Generic method to display any array
        public static void DisplayArrays<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            int i = 1;
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{i}. {item.Key} - ${item.Value}");
                i++;
            }
        }
    }

    public abstract class FoodCategories
    {
        public string CategoryName;

        public abstract void DisplayFoods();
    }

    public class MainFood : FoodCategories
    {
        public override void DisplayFoods()
        {
            CategoryName = "Main Course";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine("please choose a dish in our main course");
            Console.ResetColor();
            FoodData.DisplayArrays(new FoodData().MainCourseArray);
            ProcessOrder.processOrder(new FoodData().MainCourseArray);
        }
    }

    public class Drinks : FoodCategories
    {
        public override void DisplayFoods()
        {
            CategoryName = "Drinks";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine("please choose a drink you will like");
            Console.ResetColor();
            FoodData.DisplayArrays(new FoodData().DrinksArray);

            ProcessOrder.processOrder(new FoodData().DrinksArray);

        }
    }

    public class Appetizer : FoodCategories
    {
        public override void DisplayFoods()
        {
            CategoryName = "Appetizer";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine("please choose which appetizer you will like");
            Console.ResetColor();
            FoodData.DisplayArrays(new FoodData().AppetizerArray);
            ProcessOrder.processOrder(new FoodData().AppetizerArray);

        }
    }

    public class Desserts : FoodCategories
    {
        public override void DisplayFoods()
        {
            CategoryName = "Desserts";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine("please choose a dessert that you would like");
            Console.ResetColor();
            FoodData.DisplayArrays(new FoodData().DessertsArray);
            ProcessOrder.processOrder(new FoodData().DessertsArray);

        }
    }
}
