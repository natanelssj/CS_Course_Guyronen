using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    internal class ElectricCar :DriveByBattery
    {
        const int  m_Wheels = 5;

        int m_MaxAirPressure = 34;

        float m_MaxTimeBattery =5.4f;

        private const int k_MinDoors = 1;

        CarColor m_CarColor;

        private const int k_MaxDoors = 5;

        private int m_NumOfDoors;

        private Wheel[] m_CollectionWheels = new Wheel[m_Wheels];

        public ElectricCar()
        {
           

            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure = m_MaxAirPressure;
            }

            m_MaxTime = m_MaxTimeBattery;
        }
        public string ColorOfCar
        {
            get { return m_CarColor.ToString(); }
            set
            {
                if (Enum.TryParse(value, true, out CarColor parsedColor))
                {
                    m_CarColor = parsedColor;
                }
                else
                {
                    throw new ArgumentException($"Invalid color: {value}. Valid colors are: {string.Join(", ", Enum.GetNames(typeof(CarColor)))}");
                }
            }
        }

        public int NumOfDoors
        {
            get { return m_NumOfDoors; }
            set
            {
                if (value > 1 && value <= k_MaxDoors)
                {
                    m_NumOfDoors = value;
                }
                else
                {
                    throw new InvalidOutOfRangeException(k_MinDoors, k_MaxDoors, value);
                }
            }
        }

        public override void SetAirPressure(float i_AirPressure)
        {
            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i].m_CurrentAirPressure = i_AirPressure;
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
            return "Electric Car";
        }
    }

}

