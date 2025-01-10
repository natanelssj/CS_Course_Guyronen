using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vichle
    {
        private string m_Model;
        public string m_LicensePlate;
        private float m_EnergyPrecents;
        private int m_WheelsAmount;
        private string m_PhoneNumber;
        Status m_Status;

        private static List<string> s_LicensePlates = new List<string>(); // Static list for license plates

        internal Vichle()
        {
            m_Status = Status.InFix;
        }

        public string LicensePlate
        {
            get { return m_LicensePlate; }
            set
            {
                if (s_LicensePlates.Contains(value))
                {
                    throw new ArgumentException("License plate already exists in the system.");
                }
                if (CheckNumberOfLicense(value))
                {
                    m_LicensePlate = value;
                    s_LicensePlates.Add(value); // Add to the list
                }
                else
                {
                    throw new ArgumentException("Invalid license plate format.");
                }
            }
        }

        public string GetPhoneNumber
        {
            get { return m_PhoneNumber; }
            set { m_PhoneNumber = value; }
        }

        public float EnergyPrecents
        {
            get { return m_EnergyPrecents; }
            set { m_EnergyPrecents = value; }
        }

        public string Model
        {
            get { return m_Model; }
            set { m_Model = value; }
        }

        public int WheelsAmount
        {
            get { return m_WheelsAmount; }
            set { m_WheelsAmount = value; }
        }

        public abstract void SetAirPressure(float i_AirPressure);
        public abstract void PutPressure(float i_Pressure);
        public abstract float GetAirPressure();

        private bool CheckNumberOfLicense(string m_licensePlate)
        {
            bool isNumberOfLicense = true;
            if (m_licensePlate.Length != 7)
            {
                isNumberOfLicense = false;
            }
            int checkNum;
            if (!(int.TryParse(m_licensePlate, out checkNum)))
            {
                isNumberOfLicense = false;
            }
            return isNumberOfLicense;
        }

        public static void RemoveLicensePlate(string licensePlate) // Optional method for removing license plates
        {
            s_LicensePlates.Remove(licensePlate);
        }
        public static List<string> GetExistingLicensePlates() // Method to return the list of license plates
        {
            return new List<string>(s_LicensePlates); // Return a copy to prevent external modification
        }
    }
}
