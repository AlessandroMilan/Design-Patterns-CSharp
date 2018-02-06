using AbstractFactory.Creator;
using AbstractFactory.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactoryTest
{
    [TestClass]
    public class CISCFactoryTest
    {
        [TestMethod]
        public void CPUControlUnitMustBeCISC()
        {
            CPUFactory factory = new CISCFactory();
            CPU CentralProcessingUnit = factory.CreateCPU();

            // Must be a CISC Control Unit.
            Assert.AreEqual("CISC Control Unit", CentralProcessingUnit.ControlUnit.ToString());
        }
        [TestMethod]
        public void CPUArithmeticLogicUnitMustBeRISC()
        {
            CPUFactory factory = new CISCFactory();
            CPU CentralProcessingUnit = factory.CreateCPU();

            // Must be a CISC Arithmetic and Logic Unit.
            Assert.AreEqual("CISC Arithmetic and Logic Unit", CentralProcessingUnit.ArithmeticLogicUnit.ToString());
        }
    }
}
