namespace AbstractFactory.Product.ArithmeticLogicUnit
{
    class RISCArithmeticLogicUnit : ALU
    {
        public RISCArithmeticLogicUnit()
        {
            Architecture = "RISC";
        }

        public override string ToString()
        {
            return $"{Architecture} Arithmetic and Logic Unit";
        }
    }
}
