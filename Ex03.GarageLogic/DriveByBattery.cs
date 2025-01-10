using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    public class DriveByBattery:Vichle
    {
        public float m_TimeRemain =0;
        protected  float m_MaxTime = 0;
        private const float m_MinTime= 0;
       
        public float BatteryStatus
        {
            get { return m_TimeRemain; }
            set
            {
                if (m_MaxTime < value && m_MinTime < value)
                {
                    throw new InvalidOutOfRangeException(m_MinTime,m_MaxTime,value);
                }
                else {
                    m_TimeRemain = value;
                    EnergyPrecents =((m_TimeRemain) / (m_MaxTime) * 100);

                }
            }
        }


        public void Charge (float timeAddCharge )
        {
            
            if (timeAddCharge + m_TimeRemain <= m_TimeRemain)
            {
                m_TimeRemain += timeAddCharge;
            }
            else 
            {
                throw new  InvalidOutOfRangeException(m_TimeRemain,m_MaxTime,timeAddCharge);
            }
        }
        public override void SetAirPressure(float i_AirPressure) { }

        public override void PutPressure(float i_Pressure) { }
     
        public void ChargeBattery(int i_Time)
        {
            BatteryStatus = m_TimeRemain + i_Time;
        }

        public override float GetAirPressure() { return 0; }
    }
}

