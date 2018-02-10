using Builder.Creator;
using Builder.Director;
using Builder.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilderTest
{
    [TestClass]
    public class HawaiianPizzaBuilderTest
    {
        [TestMethod]
        public void PizzaTypeMustBeHawaiian()
        {
            PizzaShop shop = new PizzaShop();
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            Pizza pizza;

            shop.SetPizzaBuilder(hawaiianPizzaBuilder);
            shop.MakePizza();
            pizza = shop.GetPizza();

            // Must be a Hawaiian Pizza.
            Assert.AreEqual("Hawaiian", pizza.PizzaType);
        }

        [TestMethod]
        public void PizzaDoughMustBeCross()
        {
            PizzaShop shop = new PizzaShop();
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            Pizza pizza;

            shop.SetPizzaBuilder(hawaiianPizzaBuilder);
            shop.MakePizza();
            pizza = shop.GetPizza();

            // Must be a cross dough.
            Assert.AreEqual("cross", pizza.Dough);
        }

        [TestMethod]
        public void PizzaSauceMustBeMild()
        {
            PizzaShop shop = new PizzaShop();
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            Pizza pizza;

            shop.SetPizzaBuilder(hawaiianPizzaBuilder);
            shop.MakePizza();
            pizza = shop.GetPizza();

            // Must be a mild sauce.
            Assert.AreEqual("mild", pizza.Sauce);
        }
    }
}
