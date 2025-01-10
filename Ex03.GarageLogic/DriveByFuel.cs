using System;
using System.Collections.Generic;
using System.Reflection;

namespace Ex03.GarageLogic
{
    public class DriveByFuel : Vichle
    {
        public enum Fuel
        {
            Octan95,
            Octan96,
            Octan98,
            Soler
        }

        protected float m_FuelRemain = 0;
        protected float m_FuelMax = 0;
        internal Fuel m_FuelKind;
        private const float k_MinValue = 0;


     

        public float QuantityOfFuel
        {
            get { return m_FuelRemain; }
            set
            {
                if (value <= m_FuelMax && value >= k_MinValue)
                {
                    m_FuelRemain = value;
                    EnergyPrecents = (m_FuelRemain / m_FuelMax) * 100;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fuel amount exceeds tank capacity.");
                }
            }
        }
         public override void PutPressure(float i_Pressure) { }

        public override void SetAirPressure(float i_AirPressure) { }

        public string GetFuelKind()
        {
            return m_FuelKind.ToString();
        }
        
        public void PutFuel(float i_Liters, Fuel i_FuelKind)
        {

            if (m_FuelKind == i_FuelKind)
            {
                QuantityOfFuel = m_FuelRemain + i_Liters;

            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override float GetAirPressure() { return 0; }




    }
}
