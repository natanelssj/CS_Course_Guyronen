
namespace Ex03.GarageLogic
{

    public class Car
    {
        private eCarColor m_CarColor;
        private int m_NumberOfDoorsInCar;

        public Car() { }
   
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
        public int NumberOfDoorsInCar
        {
            get
            {
                return m_NumberOfDoorsInCar;
            }
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new ValueOutOfRangeException(2, 5);
                }
                m_NumberOfDoorsInCar = value;
            }
        }
    }
}
