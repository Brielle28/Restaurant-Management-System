using Restaurant_Management_System;
using System;
using static Restaurant_Management_System.MainFood;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //console app vars
            string AppName = "Restaurant Management System", Version = "1.0.0";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0}: Version {1}", AppName, Version);
            Console.ResetColor();

            //welcome note 
            Console.WriteLine("welcome to our resturant!, please choose what you want to have today");
            

            //collecting user choice and displaying use of orders 

            bool Ordering = true;

            while (Ordering)
            {
                //listing orders caterogry
                string[] categories = { "1. Main Foods", "2 .Desserts", "3 .Appetizer", "4 .Drinks", "5.exit" };

                foreach (string category in categories)
                {
                    Console.WriteLine(category);
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
                        Console.WriteLine("Exiting the program.....");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Thanks for your patronage!!!");
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
