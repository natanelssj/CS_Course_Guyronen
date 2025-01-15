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

        
        public static Vichle  ChoosingVichle(string choice)
        {

           Vichle vichle=null;
            switch (choice)
            {
                case "1":
                    vichle = CreateFuelMotorcycle();
                    break;
                case "2":
                    vichle = CreateElectricMotorcycle();
                    break;
                case "3":
                    vichle = CreatePrivateCar();
                    break;
                case "4":
                    vichle = CreateElectricCar();
                    break;
                case "5":
                    vichle = CreateTruck();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid vehicle type.");
                    break;

            }
            return vichle;
        }
        private static Vichle CreateElectricMotorcycle()
        {

            ElectricMotorcycle electricMotorcycle = new ElectricMotorcycle();
            setCommonVehicleProperties(electricMotorcycle);
            Console.WriteLine("Enter Remaining Time of Battery:");
            electricMotorcycle.AvailableBatteryHours = ValidInput.GetValidFloat(0, 2.9f);
            Console.Write("Enter engine volume: ");
            electricMotorcycle.Engine = ValidInput.GetValidChoice(50, 2000);
            Console.WriteLine("Choose license type:");
            Console.WriteLine("1. A1");
            Console.WriteLine("2. A2");
            Console.WriteLine("3. AB");
            Console.WriteLine("4. B1");
            int licenseTypeChoice = ValidInput.GetValidChoice(1, 4);
            electricMotorcycle.LicenseCategory = (eLicenseCategory)(licenseTypeChoice - 1);
            return electricMotorcycle;

        }
        
        private static  Vichle CreateFuelMotorcycle()
        {
            FuelMotorcycle motorcycle = new FuelMotorcycle();
            setCommonVehicleProperties(motorcycle);
            Console.WriteLine("Enter amount of Fuel:");
            motorcycle.QuantityOfFuel = ValidInput.GetValidFloat(0, 6.2f);
            Console.Write("Enter engine volume: ");
            motorcycle.Engine= ValidInput.GetValidChoice(50, 2000);
            Console.WriteLine("Choose license type:");
            Console.WriteLine("1. A1");
            Console.WriteLine("2. A2");
            Console.WriteLine("3. AB");
            Console.WriteLine("4. B1");
            int licenseTypeChoice = ValidInput.GetValidChoice(1, 4);
            motorcycle.LicenseCategory = (eLicenseCategory)(licenseTypeChoice - 1);
            return motorcycle;
        }

        private static Vichle CreatePrivateCar()
        {
            PrivateCar privateCar = new PrivateCar();
            setCommonVehicleProperties (privateCar);
            Console.WriteLine("Enter amount of Fuel:");
//            truck.QuantityOfFuel = GetValidFloat(0, truck.m_MaxTankFuel);
            privateCar.QuantityOfFuel= ValidInput.GetValidFloat(0, 52f);
            Console.WriteLine("Choose Color car :");
            Console.WriteLine("1. Blue");
            Console.WriteLine("2. White");
            Console.WriteLine("3. Black");
            Console.WriteLine("4. Red");
            int Carcolor = ValidInput.GetValidChoice(1, 4);
            privateCar.CarColor= (eCarColor)(Carcolor - 1);
            Console.WriteLine("Enter Number Of Doors (2,3,4,5):");
            privateCar.NumOfDoors=ValidInput.GetValidChoice(2, 5);
            return privateCar;
        }

        private static Vichle CreateElectricCar()
        {
            ElectricCar electricCar = new ElectricCar();
            setCommonVehicleProperties(electricCar);
            Console.WriteLine("Enter Remaining Time of Battery:");
            electricCar.AvailableBatteryHours= ValidInput.GetValidFloat(0, 5.4f);
            Console.WriteLine("Choose Color car :");
            Console.WriteLine("1. Blue");
            Console.WriteLine("2. White");
            Console.WriteLine("3. Black");
            Console.WriteLine("4. Red");
            int Carcolor = ValidInput.GetValidChoice(1, 4);
            electricCar.CarColor = (eCarColor)(Carcolor - 1);
            Console.WriteLine("Enter Number Of Doors (2,3,4,5):");
            electricCar.NumOfDoors = ValidInput.GetValidChoice(2, 5);
            return electricCar;
        }

        private static Vichle CreateTruck() {
            Truck truck = new Truck();
            Console.WriteLine("Enter amount of Fuel:");
            truck.QuantityOfFuel=ValidInput.GetValidFloat(0, truck.m_MaxTankFuel);
            setCommonVehicleProperties(truck);
            Console.Write("Enter cargo volume: ");
            truck.CargoVolume = ValidInput.GetValidFloat(0, 1000f);
            Console.Write("Is carrying dangerous materials (y/n): ");
            truck.IsTransportRefrigeratedMaterials = Console.ReadLine().ToLower() == "y";
            return truck;
        }

        private static  void setCommonVehicleProperties(Vichle i_vehicle)
        {
            Console.Write("Enter model name: ");
            i_vehicle.Model = Console.ReadLine();
            i_vehicle.Wheels = getWheelsInput(i_vehicle);
        }

        private static  List<Wheel> getWheelsInput(Vichle i_Vehicle)
        {
            List<Wheel> wheels = new List<Wheel>();
            int numberOfWheels = 0;
            float maxAirPressure = 0;
            if (i_Vehicle is PrivateCar || i_Vehicle is ElectricCar)
            {
                numberOfWheels = 5;
                maxAirPressure = 34;
            }
            else if (i_Vehicle is FuelMotorcycle || i_Vehicle is ElectricMotorcycle)
            {
                numberOfWheels = 2;
                maxAirPressure = 32;
            }
            else if (i_Vehicle is Truck)
            {
                numberOfWheels = 14;
                maxAirPressure = 29;
            }

            Console.Write("Enter manufacturer name: ");
            string manufacturer = Console.ReadLine() ?? throw new ArgumentNullException("Manufacturer name cannot be null");
            Console.Write("Enter wheels air pressure: ");
            float airPressure =ValidInput.GetValidFloat(0, maxAirPressure);
            for (int i = 0; i < numberOfWheels; i++)
            {
                Wheel wheel = new Wheel(manufacturer, maxAirPressure, airPressure);
                wheels.Add(wheel);
            }

            return wheels;
        }
        
    }

}

