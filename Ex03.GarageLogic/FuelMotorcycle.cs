using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelMotorcycle:DriveByFuel
    {
        const  int m_Wheels = 2;

        public eLicenseCategory m_LicenseType;

        int EngineDisplacementCc = 0;

        int m_MaxAirPressure = 32;

        float m_MaxFuelTank = 6.2f;

        eFuelType k_MotorcycleFuel = eFuelType.Octan98;

        Wheel[] m_CollectionWheels=new Wheel[m_Wheels];   

        public FuelMotorcycle()
        {

            m_FuelMax = m_MaxFuelTank;
            m_FuelKind = k_MotorcycleFuel;

            /*for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure = m_MaxAirPressure;
            }
            */

        }
        public eLicenseCategory LicenseCategory
        {
            get
            {
                return m_LicenseType;
            }
            set
            {
                m_LicenseType = value;
            }
        }

        /*public override void SetAirPressure(float i_AirPressure)
        {
            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i].m_CurrentAirPressure = i_AirPressure;
            }
        }*/

        public int Engine
        {
            get { return EngineDisplacementCc; }
            set { EngineDisplacementCc = value; }
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
            return "Motorcycle";
        }

    }
}
