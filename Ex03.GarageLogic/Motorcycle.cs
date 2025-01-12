using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Motorcycle:DriveByFuel
    {
        const  int m_Wheels = 2;

        LicenseType m_LicenseType;

        int EngineDisplacementCc = 0;

        int m_MaxAirPressure = 32;

        float m_MaxFuelTank = 6.2f;

        Fuel k_MotorcycleFuel = Fuel.Octan98;

        Wheel[] m_CollectionWheels=new Wheel[m_Wheels];   

     public Motorcycle()
        {

            m_FuelMax = m_MaxFuelTank;
            m_FuelKind = k_MotorcycleFuel;

            for (int i = 0; i < m_Wheels; i++)
            {
                m_CollectionWheels[i] = new Wheel();
                m_CollectionWheels[i].MaxAirPressure = m_MaxAirPressure;
            }


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
                m_CollectionWheels[i].m_CurrentAirPressure = i_AirPressure;
            }


        }

        public int  GetEngin;

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
            return "Private Car";
        }

    }
}
