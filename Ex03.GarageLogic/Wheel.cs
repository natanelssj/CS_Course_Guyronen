using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03
{
    internal class Wheel
    {
        private string m_ManufacturerName;
        internal float m_CurrentAirPressure;
        private float m_MaxAirPressure;
        private float m_MinAirPressure=0;


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
                    throw new InvalidOutOfRangeException(m_MinAirPressure, m_MaxAirPressure, value);
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
                throw new InvalidOutOfRangeException(m_MinAirPressure, m_MaxAirPressure, m_CurrentAirPressure + i_AirToAdd);
            }
        }
    }
}
