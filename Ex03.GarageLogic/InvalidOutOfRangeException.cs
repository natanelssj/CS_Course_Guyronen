using System;

namespace Ex03.GarageLogic
{
    public class InvalidOutOfRangeException : Exception
    {
        private readonly float m_MaxValue;
        private readonly float m_MinValue;
        private readonly string m_ExceptionMessage;

        public InvalidOutOfRangeException(float i_MinValue, float i_MaxValue, float i_InvalidNum)
        {
            m_MinValue = i_MinValue;
            m_MaxValue = i_MaxValue;
            m_ExceptionMessage = string.Format(
                $"Error: The value {i_InvalidNum} is out of range. Valid range: ({m_MinValue}+{m_MaxValue})/{m_MaxValue}",
                i_InvalidNum,
                m_MinValue,
                m_MaxValue
            );
        }

        public override string Message => m_ExceptionMessage;
    }
}
