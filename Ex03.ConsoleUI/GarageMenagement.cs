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
        private   GarageManager garageManager;

        public GarageMenagement()
        {
            garageManager = new GarageManager();
        }
        public void Start()
        {

            bool exitProgram = false;
            while (!exitProgram)
            {
                MenuPrints.PrintMainMenu();
                string userChoise = "";
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        InsertVichle();
                        break;
                    case "2":
                        displayLicenseNumbers();
                        break;
                           case"3":
                               changeVehicleStatus();
                               break;
                      /*     case 4:
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
        public void  InsertVichle()
        {
            try
            {
                Console.WriteLine("Enter Number of Licence Plate:");
                string licensePlate = Console.ReadLine();

                if (garageManager.IsLicensePlateExists(licensePlate))
                {
                    IfLicenceExist();
                    waitForUserInput();
                    return;
                }

                Console.WriteLine("Enter Owner Name:");
                string ownerName = Console.ReadLine();

                Console.WriteLine("Enter Owner Phone:");
                string phoneNumber = Console.ReadLine();

                Console.Clear();
                MenuPrints.PrintInsertNewVhicleMenu();
                string choice = Console.ReadLine();

                Vichle vichle = Factory.ChoosingVichle(choice);
                vichle.LicensePlate = licensePlate;
                vichle.OwnerName = ownerName;
                vichle.GetPhoneNumber = phoneNumber;

                garageManager.AddVehicleToGarage(vichle);
                Console.WriteLine("Vehicle added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            waitForUserInput();
        }
        private void displayLicenseNumbers()
        {
            string filterStatusChoice;
            while (true)
            {
                filterStatusChoice = GetFilterStatusFromUser();
                if (filterStatusChoice == "y" || filterStatusChoice == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter 'y' or 'n'");
                }
            }

            if (filterStatusChoice == "y")
            {
                eGarageVehicleStatus status = GetStatusChoiceFromUser();
                var licenseNumbers = garageManager.GetLicenseNumbersFilteredByStatus(status);
                foreach (string licenseNumber in licenseNumbers)
                {
                    Console.WriteLine(licenseNumber);
                }
            }
            else
            {
                var licenseNumbers = garageManager.GetLicenseNumbersWithoutFilters();
                foreach (string licenseNumber in licenseNumbers)
                {
                    Console.WriteLine(licenseNumber);
                }
            }
            waitForUserInput();
        }




        public eGarageVehicleStatus GetStatusChoiceFromUser()
        {
            Console.WriteLine("Choose a status to filter by:");
            Console.WriteLine("1. In Repair");
            Console.WriteLine("2. Repaired");
            Console.WriteLine("3. Paid");
            int statusChoice =Factory.GetValidChoice(1, 3);

            return (eGarageVehicleStatus)(statusChoice - 1);
        }


        public void changeVehicleStatus()
        { 
            eGarageVehicleStatus Status;
            Console.WriteLine("Enter Number of Licence Plate:");
            string licensePlate = Console.ReadLine();

            if (!garageManager.IsLicensePlateExists(licensePlate))
            {
                Console.WriteLine($"No vehicle found with license number:{licensePlate}");
                waitForUserInput();
                return;
            }
            else 
            {
                eGarageVehicleStatus newStatus = GetStatusChoiceFromUser();
                garageManager.ChangeStatusToVehicle(licensePlate, newStatus);
                Console.WriteLine("Vehicle status updated successfully");
            }

        }

        public void PrintVichle() { }

        private void IfLicenceExist()
        {
            Console.WriteLine("The vehicle already exists in the garage.");
            Console.WriteLine("What whould you like to do:");

        }
        private void waitForUserInput()
        {
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
        public string GetFilterStatusFromUser()
        {
            Console.Write("Filter by status? (y/n): ");

            return Console.ReadLine() ?? throw new ArgumentNullException("Filter choice cannot be null");
        }
    }
}
