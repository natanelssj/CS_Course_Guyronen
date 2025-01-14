using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vichle
    {
        private string m_Model;
        public string m_LicensePlate;
        private float m_EnergyPrecents;
        private List<Wheel> m_Wheels;
        private string m_PhoneNumber;
        private string m_Name;
        public eGarageVehicleStatus m_Status;

        private static List<string> s_LicensePlates = new List<string>(); // Static list for license plates

        public Vichle()
        {
            m_Status = eGarageVehicleStatus.InRepair;
        }
        public string OwnerName
        {
            get {return m_Name;}
            set {m_Name = value;}
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

        public List<Wheel> Wheels
        {
            get
            {
                return m_Wheels;
            }
            set
            {
                m_Wheels = value;
            }
        }

        public abstract void SetAirPressure(float i_AirPressure);
        public abstract void PutPressure(float i_Pressure);
        public abstract float GetAirPressure();

        private bool CheckNumberOfLicense(string m_licensePlate)
        {
            bool isNumberOfLicense = true;
            int checkNum;
            if (!(int.TryParse(m_licensePlate, out checkNum)))
            {
                isNumberOfLicense = false;
            }
            return isNumberOfLicense;
        }
        public static bool IsLicensePlateExists(string licensePlate)
        {
            return s_LicensePlates.Contains(licensePlate);
        }

        public static List<string> GetExistingLicensePlates(string platesToCheck)
        {
            List<string> existingPlates = new List<string>();

            foreach (var plate in existingPlates)
            {
                if (s_LicensePlates.Contains(plate))
                {
                    existingPlates.Add(plate);
                }
            }

            return existingPlates;

        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Model name: {m_Model}");
            stringBuilder.AppendLine($"License number: {m_LicensePlate}");
            stringBuilder.AppendLine("Wheels:");
            for (int i = 0; i < Wheels.Count; i++)
            {
                stringBuilder.AppendLine($"    {Wheels[i].ToString()}");
            }

            return stringBuilder.ToString();
        }
    }
}
