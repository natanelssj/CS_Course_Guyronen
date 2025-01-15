using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
   public  class PrivateCar: DriveByFuel
    {

        eCarColor m_CarColor;


        private int k_MaxDoors=5;

        private int k_MinDoors = 2;

        const int m_Wheels = 5;

        private int m_NumOfDoors;
        
        int m_MaxAirPressure = 34;

        float m_FuelTank = 52;

        private eFuelType k_PrivateFuel = eFuelType.Octan95;

        private Wheel[] m_CollectionWheels=new Wheel[m_Wheels];
       
        public PrivateCar()
        {

            m_FuelMax = m_FuelTank;
            m_FuelKind = k_PrivateFuel;

            /*for (int i = 0;i< m_Wheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure=m_MaxAirPressure;
            }*/
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
            stringBuilder.AppendLine($"Color: {CarColor}");
            stringBuilder.AppendLine($"Number of doors: {NumOfDoors}");

            return stringBuilder.ToString();
        }
    }
}
