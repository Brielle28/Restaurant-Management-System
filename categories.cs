using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    public class FoodData
    {
        public string[] MainCourseArray = { "1. Jollof Rice - $5.00", "2. Fried Rice - $6.50", "3. Spaghetti - $8.50", "4. Yam and Egg Sauce - $10.50" };
        public string[] DrinksArray = { "1. Coke - $2.00", "2. Fanta - $2.50", "3. Cocktail - $1.50", "4. Energy Drink - $3.50" };
        public string[] AppetizerArray = { "1. Pizza - $1.50", "2. Donuts - $3.50", "3. Beef Wraps - $2.50", "4. Chips - $2.00" };
        public string[] DessertsArray = { "1. Dessert_1 - $2.00", "2. Dessert_2 - $2.00", "3. Dessert_3 - $2.00", "4. Dessert_4 - $2.00" };


        // Generic method to display any array
        public static void DisplayArrays<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
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
            ProcessOrder.Process0rder(new FoodData().MainCourseArray);
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

            ProcessOrder.Process0rder(new FoodData().DrinksArray);

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
            ProcessOrder.Process0rder(new FoodData().AppetizerArray);

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
            ProcessOrder.Process0rder(new FoodData().DessertsArray);

        }
    }
}
