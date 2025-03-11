using Restaurant_Management_System;
using System;
using System.Collections.Generic;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console app vars
            string appName = "Restaurant Management System";
            string version = "1.0.0";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0}: Version {1}", appName, version);
            Console.ResetColor();

            Console.WriteLine("Welcome! We're delighted to have you. Please enjoy your dining experience.");

            Console.WriteLine("How may we assist you today? Please choose from the following services:");
            bool isServices = true;

            while (isServices)
            {

                var services = new Dictionary<int, string>
                {
                    { 1, "Place a Food Order" },
                    { 2, "Reserve a Table" },
                    { 3, "Speak to a customer care representative" },
                    { 4, "exit the program" }
                };

                foreach (KeyValuePair<int, string> kv in services)
                {
                    Console.WriteLine($"{kv.Key}. {kv.Value}");
                }

                string serviceUserInput = Console.ReadLine();
                int serviceUserChoice;

                if (int.TryParse(serviceUserInput, out serviceUserChoice))
                {
                    switch (serviceUserChoice)
                    {
                        case 1:
                            OrderHandler.StartOrdering();
                            break;
                        case 2:
                            TableReservation.ReserveTable();
                            break;
                        case 3:
                            CustomerCare.SpeakToRepresentative();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Thanks for your patronage, wish to see you again later");
                            Console.ResetColor();
                            isServices = false;
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