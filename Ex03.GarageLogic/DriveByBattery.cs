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

        public float m_AvailableEnergyValue;
        public float m_MaxEnergyValue;
        public float AvailableBatteryHours
        {
            get
            {
                return m_AvailableEnergyValue;
            }
            set
            {
                m_AvailableEnergyValue = value;
            }
        }

        public float MaxBatteryHours
        {
            get
            {
                return m_MaxEnergyValue;
            }
            set
            {
                m_MaxEnergyValue = value;
            }
        }

        public void Charge(float i_HoursToCharge)
        {
            if (AvailableBatteryHours + i_HoursToCharge > MaxBatteryHours)
            {
                float maxNumberOfHoursPossibleToCharge = MaxBatteryHours - AvailableBatteryHours;
                throw new ValueOutOfRangeException(0, maxNumberOfHoursPossibleToCharge);
            }

            AvailableBatteryHours += i_HoursToCharge;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Available battery hours: {AvailableBatteryHours}");
            stringBuilder.Append($"Max battery hours: {MaxBatteryHours}");

            return stringBuilder.ToString();
        }


        public override void SetAirPressure(float i_AirPressure) { }

        public override void PutPressure(float i_Pressure) { }

        public override float GetAirPressure() { return 0; }
    }
}

