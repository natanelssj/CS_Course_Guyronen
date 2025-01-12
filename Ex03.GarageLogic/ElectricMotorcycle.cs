﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03.GarageLogic {

    public class ElectricMotorcycle : DriveByBattery
    {
        const int m_Wheels = 2;

        LicenseType m_LicenseType;

        int EngineDisplacementCc = 0;

        int m_AirMaxPressure = 32;

        float m_MaxTimeBattery = 2.9f;

        private Wheel[] m_CollectionWheels = new Wheel[m_Wheels];

        public ElectricMotorcycle()
        {
            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure = m_AirMaxPressure;
            }
            m_MaxTime = m_MaxTimeBattery;
        }
        public int Engine
        {
            get { return EngineDisplacementCc; }
            set { EngineDisplacementCc = value; }
        }

        public string License
        {
            get { return m_LicenseType.ToString(); }
            set
            {
                if (Enum.TryParse(value, true, out LicenseType LicenceIndex))
                {
                    m_LicenseType = LicenceIndex;
                }
                else
                {
                    throw new ArgumentException($"Invalid color: {value}. Valid colors are: {string.Join(", ", Enum.GetNames(typeof(CarColor)))}");
                }
            }
        }

        public override void SetAirPressure(float i_AirPressure)
        {
            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i].CurrentAirPressure = i_AirPressure;
            }
        }

        public override void PutPressure(float i_Pressure)
        {
            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i].AddAir(i_Pressure);
            }
        }

        public override float GetAirPressure()
        {
            return m_CollectionWheels[0].CurrentAirPressure;
        }

        public override string ToString()
        {
            return "Electric Motorcycle";
        }


    }



}
