namespace AbstractFactory.Product.ControlUnit
{
    class RISCControlUnit : CU
    {

        public RISCControlUnit()
        {
            Architecture = "RISC";
        }

        public override string ToString()
        {
            return $"{Architecture} Control Unit";
        }
    }
}
