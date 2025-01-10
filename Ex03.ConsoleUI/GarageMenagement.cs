using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class GarageMenagement
    {
        public static void Start()
        {
            string choice=null;

            while (choice != "4") 
            {
                Console.Clear();
                MenuPrints.PrintMainMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertVichle();
                        break;

                    case "2":
                        ManageVichle();
                        break;

                    case "3":
                        PrintVichle();
                        break;

                    case "4":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            } 
        }
        public static void InsertVichle()
        {
            try
            {
                Console.WriteLine("Enter Number of Licence Plate:");
                string licensePlate = Console.ReadLine();

                // בדיקה אם מספר הרישוי כבר קיים
                if (IsLicensePlateExists(licensePlate))
                {
                    Console.WriteLine("The vehicle already exists in the garage. Returning to main menu.");
                    return;
                }

                // אם מספר הרישוי חדש, הוסף אותו והמשך
                Console.Clear();
                MenuPrints.PrintInsertNewVhicleMenu();
                string choice = Console.ReadLine();
                Console.WriteLine("Creating New ");
                /*
                Vichle newVichle = CreateVehicleByChoice(choice, licensePlate)// יצירת רכב חדש
                if (newVichle != null)
                {
                    GarageManagement.AddVehicle(newVichle); // הוספת הרכב לניהול המוסך
                    Console.WriteLine("The vehicle has been successfully added to the garage.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Returning to main menu.");
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static bool IsLicensePlateExists(string licensePlate)
        {
            return Vichle.GetExistingLicensePlates().Contains(licensePlate);
        }
        public static void ManageVichle() { }

        public static void PrintVichle() { }
    }
}
