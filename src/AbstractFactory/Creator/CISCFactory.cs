using AbstractFactory.Product.ArithmeticLogicUnit;
using AbstractFactory.Product.ControlUnit;

namespace AbstractFactory.Creator
{
    public class CISCFactory : CPUFactory
    {
        protected override ALU CreateArithmeticLogicUnit()
        {
            return new CISCArithmeticLogicUnit();
        }

        protected override CU CreateControlUnit()
        {
            return new CISCControlUnit();
        }
    }
}
