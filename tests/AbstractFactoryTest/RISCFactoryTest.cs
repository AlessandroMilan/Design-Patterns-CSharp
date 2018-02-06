using AbstractFactory.Creator;
using AbstractFactory.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactoryTest
{
    [TestClass]
    public class RISCFactoryTest
    {
        [TestMethod]
        public void CPUControlUnitMustBeRISC()
        {
            CPUFactory factory = new RISCFactory();
            CPU CentralProcessingUnit = factory.CreateCPU();

            // Must be a RISC Control Unit.
            Assert.AreEqual("RISC Control Unit", CentralProcessingUnit.ControlUnit.ToString());
        }
        [TestMethod]
        public void CPUArithmeticLogicUnitMustBeRISC()
        {
            CPUFactory factory = new RISCFactory();
            CPU CentralProcessingUnit = factory.CreateCPU();

            // Must be a RISC Arithmetic and Logic Unit.
            Assert.AreEqual("RISC Arithmetic and Logic Unit", CentralProcessingUnit.ArithmeticLogicUnit.ToString());
        }
    }
}
