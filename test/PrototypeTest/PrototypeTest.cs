using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;
using Prototype.Concrete;

namespace PrototypeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsePrototypeTest()
        {
            // Create two instances and clone each
            IPrototype p1 = new ConcretePrototypeOne();
            IPrototype p2 = new ConcretePrototypeTwo();
            ConcretePrototypeOne c1 = (ConcretePrototypeOne)p1.Clone();
            ConcretePrototypeTwo c2 = (ConcretePrototypeTwo)p2.Clone();

            Assert.AreEqual("One", c1.Id);
            Assert.AreEqual("Two", c2.Id);

        }
    }
}
