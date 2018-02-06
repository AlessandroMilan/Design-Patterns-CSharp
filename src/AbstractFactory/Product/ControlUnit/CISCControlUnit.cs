namespace AbstractFactory.Product.ControlUnit
{
    class CISCControlUnit : CU
    {
        public CISCControlUnit()
        {
            Architecture = "CISC";
        }

        public override string ToString()
        {
            return $"{Architecture} Control Unit";
        }
    }
}
