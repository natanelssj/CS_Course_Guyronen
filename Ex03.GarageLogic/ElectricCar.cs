using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public class ElectricCar :DriveByBattery
    {
        const int  m_Wheels = 5;

        int m_MaxAirPressure = 34;

        float m_MaxTimeBattery =5.4f;

        private const int k_MinDoors = 1;

        eCarColor m_CarColor;

        private const int k_MaxDoors = 5;

        private int m_NumOfDoors;

        private Wheel[] m_CollectionWheels = new Wheel[m_Wheels];
        


        public ElectricCar()
        {


            /*for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure = m_MaxAirPressure;
            }*/

            m_MaxEnergyValue = m_MaxTimeBattery;
        }

        public eCarColor CarColor
        {
            get
            {
                return m_CarColor;
            }
            set
            {
                m_CarColor = value;
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
                    throw new ValueOutOfRangeException(k_MinDoors, k_MaxDoors);
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
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Car Color: {CarColor}");
            stringBuilder.AppendLine($"Number of Doors: {m_NumOfDoors}");

            return stringBuilder.ToString();
        }
    }

}

