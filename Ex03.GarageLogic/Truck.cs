using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck:DriveByFuel
    {
        bool m_isTransportRefrigeratedMaterials;

        float m_CargoVolume;

        private const int k_NumOfWheels = 14;

        private Wheel[] m_CollectionWheels = new Wheel[k_NumOfWheels];
        
        int m_MaxAirPressure = 29;
        
        eFuelType m_FuelKind= eFuelType.Soler;

        float m_MaxTankFuel = 125;

        public Truck() 
        {
            m_FuelMax = m_MaxTankFuel;
            m_FuelKind = m_FuelKind;

           /* for (int i = 0; i < k_NumOfWheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure = m_MaxAirPressure;
            }*/

        }
        public bool IsTransportRefrigeratedMaterials 
        {
            get { return m_isTransportRefrigeratedMaterials; }
            set { m_isTransportRefrigeratedMaterials = value; }
        }


        public override void SetAirPressure(float i_AirPressure)
        {
            for (int i = 0; i < k_NumOfWheels; i++)
            {
                m_CollectionWheels[i].m_CurrentAirPressure = i_AirPressure;
            }


        }

        public override void PutPressure(float i_Pressure)
        {
            for (int i = 0; i < k_NumOfWheels; i++)
            {
                m_CollectionWheels[i].AddAir(i_Pressure);
            }
        }

        public override float GetAirPressure()
        {
            return m_CollectionWheels[0].CurrentAirPressure;
        }


        public float CargoVolume 
        {
            get { return m_CargoVolume; }
            set
            {
                m_CargoVolume = value;
            }

        }
        public override string ToString()
        {
            return "Truck";

        }

    }
}
 