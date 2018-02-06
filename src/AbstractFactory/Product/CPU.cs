using AbstractFactory.Product.ArithmeticLogicUnit;
using AbstractFactory.Product.ControlUnit;

namespace AbstractFactory.Product
{
    public class CPU
    {
        public ALU ArithmeticLogicUnit { get; }
        public CU ControlUnit { get; }

        public CPU(ALU arithmeticLogicUnit, CU controlUnit)
        {
            ArithmeticLogicUnit = arithmeticLogicUnit;
            ControlUnit = controlUnit;
        }
    }
}
