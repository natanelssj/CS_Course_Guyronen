using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private Dictionary<string, Vichle> m_Vehicles;

        public GarageManager()
        {
            m_Vehicles = new Dictionary<string, Vichle>();
        }

        public bool IsLicensePlateExists(string licensePlate)
        {
            return m_Vehicles.ContainsKey(licensePlate);
        }

        public void AddVehicleToGarage(Vichle i_Vehicle)
        {
            m_Vehicles.Add(i_Vehicle.LicensePlate, i_Vehicle);
        }
        public bool VehicleIsAlreadyInGarage(string i_LicenseNumber)
        {
            return m_Vehicles.ContainsKey(i_LicenseNumber);
        }
        public List<string> GetLicenseNumbersWithoutFilters()
        {
            return m_Vehicles.Keys.ToList();
        }
        public List<string> GetLicenseNumbersFilteredByStatus(eGarageVehicleStatus i_Status)
        {
            List<string> licenseNumbers = new List<string>();
            foreach (var vehicle in m_Vehicles)
            {
                if (vehicle.Value.m_Status == i_Status)
                {
                    licenseNumbers.Add(vehicle.Key);
                }
            }

            return licenseNumbers;
        }
        public void ChangeStatusToVehicle(string licensePlate, eGarageVehicleStatus newStatus)
        {
            if (!m_Vehicles.ContainsKey(licensePlate))
            {
                throw new ArgumentException("Vehicle not found");
            }
            m_Vehicles[licensePlate].m_Status = newStatus;

        }
        public void RefuelVehicle(string i_LicenseNumber, eFuelType i_FuelType, float i_LitersToRefuel)
        {
            if (!m_Vehicles.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Vehicle not found");
            }

            if (m_Vehicles[i_LicenseNumber] is DriveByFuel fuelEngine)
            {
                fuelEngine.PutFuel(i_LitersToRefuel, i_FuelType);
            }
            else
            {
                throw new ArgumentException("The vehicle is not a fuel-based vehicle and cannot be refueled");
            }
        }

        public void AddAirVehicleWheels(string i_LicenseNumber)
        {
            if (!m_Vehicles.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Vehicle not found");
            }

            foreach (var wheel in m_Vehicles[i_LicenseNumber].Wheels)
            {
                wheel.AddAir(wheel.MaxAirPressure - wheel.CurrentAirPressure);
            }
        }
        public void RechargeVehicle(string i_LicenseNumber, float i_MinutesToCharge)
        {
            if (!m_Vehicles.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Vehicle not found");
            }

            if (m_Vehicles[i_LicenseNumber] is DriveByBattery electricEngine)
            {
                float hoursToCharge = i_MinutesToCharge / 60;
                electricEngine.Charge(hoursToCharge);
            }
            else
            {
                throw new ArgumentException("The vehicle is not an electric vehicle and cannot be charged");
            }
        }


        public string GetVehicleDetails(string i_LicenseNumber)
        {
            if (!m_Vehicles.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Vehicle not found");
            }
            return m_Vehicles[i_LicenseNumber].ToString();
        }

    }
   
}

