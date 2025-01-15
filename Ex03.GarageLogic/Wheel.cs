using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03
{
    public  class Wheel
    {
        private string m_ManufacturerName;
        internal float m_CurrentAirPressure;
        private float m_MaxAirPressure;
        private float m_MinAirPressure = 0;

        public Wheel(string i_ManufacturerName, float i_MaxAirPressure,float i_CurrenAirPressur) 
        {
            m_ManufacturerName=i_ManufacturerName;
            m_MaxAirPressure=i_MaxAirPressure;
            m_CurrentAirPressure=i_CurrenAirPressur;

        }

        string ManufacturerName 
        {
            get { return m_ManufacturerName; }
            set
            {
                m_ManufacturerName = value;
            }
        }
        internal float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set
            {
                if (value <= m_MaxAirPressure && value >= 0)
                {
                    m_CurrentAirPressure = value;
                }
                else 
                {
                    throw new ValueOutOfRangeException(m_MinAirPressure, m_MaxAirPressure);
                }
            }
        }        
        internal float MaxAirPressure
        {
            get { return m_MaxAirPressure; }
            set
            {
                m_MaxAirPressure = value;
            }
        }

        public void AddAir(float i_AirToAdd)
        {
            if (m_CurrentAirPressure + i_AirToAdd <= m_MaxAirPressure)
            {
                m_CurrentAirPressure += i_AirToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(m_MinAirPressure, m_MaxAirPressure);
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{{Manufacturer Name: {0}, Current Air Pressure: {1}, Max Air Pressure: {2}}}",
                            ManufacturerName, CurrentAirPressure, MaxAirPressure);

            return stringBuilder.ToString();
        }
    }
}
