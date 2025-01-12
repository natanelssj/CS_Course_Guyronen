using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class Factory
    {
        public static void  ChoosingVichle(string choice)
        {
            Vichle newVehicle = null;

            switch (choice)
            {
                case "1":
                    newVehicle = new ElectricMotorcycle();
                    break;
                case "2":
                    newVehicle = new Motorcycle();
                    break;
                case "3":
                    newVehicle = new ElectricCar();
                    break;
                case "4":
                    newVehicle = new PrivateCar();
                    break;
                case "5":
                    newVehicle = new Truck();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid vehicle type.");
                    break;

            }
            DetailesVichle(newVehicle);
        }
        public static void DetailesVichle(Vichle vichle)
        {
            int Air=int.Parse(Console.ReadLine());
            int Fuel = int.Parse(Console.ReadLine());
            vichle.SetAirPressure(Air);
            switch (vichle.ToString())
            {
                case "Electric Motorcycle":
                    break;
            }    
            
        

        }
    }
}

