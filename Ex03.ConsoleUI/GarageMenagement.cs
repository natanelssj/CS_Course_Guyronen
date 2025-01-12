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

            MenuPrints.PrintMainMenu();
            bool exitProgram = false;
            while (!exitProgram)
            {
                string userChoise = "";
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        InsertVichle();
                        break;
             /*       case 2:
                        displayLicenseNumbers();
                        break;
                    case 3:
                        changeVehicleStatus();
                        break;
                    case 4:
                        inflateVehicleTires();
                        break;
                    case 5:
                        refuelVehicle();
                        break;
                    case 6:
                        rechargeVehicle();
                        break;
                    case 7:
                        displayVehicleInformation();
                        break;*/
                    case "8":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
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
                Factory.ChoosingVichle(choice);

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
