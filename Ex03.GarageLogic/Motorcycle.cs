namespace Ex03.GarageLogic
{

    public class Motorcycle
    {
        private eLicenseCategory m_LicenseCategory;
        private int m_EngineVolumeInCC;

        public Motorcycle()
        {
            
        }

        public eLicenseCategory LicenseCategory
        {
            get
            {
                return m_LicenseCategory;
            }
            set
            {
                m_LicenseCategory = value;
            }
        }

        public int EngineVolumeInCC
        {
            get
            {
                return m_EngineVolumeInCC;
            }
            set
            {
                m_EngineVolumeInCC = value;
            }
        }
    }
}