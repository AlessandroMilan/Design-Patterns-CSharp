using AbstractFactory.Product.ArithmeticLogicUnit;
using AbstractFactory.Product.ControlUnit;

namespace AbstractFactory.Creator
{
    public class RISCFactory : CPUFactory
    {
        protected override ALU CreateArithmeticLogicUnit()
        {
            return new RISCArithmeticLogicUnit();
        }

        protected override CU CreateControlUnit()
        {
            return new RISCControlUnit();
        }
    }
}
