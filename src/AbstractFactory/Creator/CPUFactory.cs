using AbstractFactory.Product;
using AbstractFactory.Product.ArithmeticLogicUnit;
using AbstractFactory.Product.ControlUnit;

namespace AbstractFactory.Creator
{
    public abstract class CPUFactory
    {
        protected abstract ALU CreateArithmeticLogicUnit();
        protected abstract CU CreateControlUnit();

        public CPU CreateCPU()
        {
            ALU arithmeticLogicUnit = CreateArithmeticLogicUnit();
            CU controlUnit = CreateControlUnit();

            return new CPU(arithmeticLogicUnit, controlUnit);
        }
    }
}
