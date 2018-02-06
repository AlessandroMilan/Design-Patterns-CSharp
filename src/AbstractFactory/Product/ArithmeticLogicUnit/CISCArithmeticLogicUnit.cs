namespace AbstractFactory.Product.ArithmeticLogicUnit
{
    class CISCArithmeticLogicUnit : ALU
    {
        public CISCArithmeticLogicUnit()
        {
            Architecture = "CISC";
        }

        public override string ToString()
        {
            return $"{Architecture} Arithmetic and Logic Unit";
        }
    }
}
