using Builder.Creator;
using Builder.Director;
using Builder.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilderTest
{
    [TestClass]
    public class SpicyPizzaBuilderTest
    {
        [TestMethod]
        public void PizzaTypeMustBeSpicy()
        {
            PizzaShop shop = new PizzaShop();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            Pizza pizza;

            shop.SetPizzaBuilder(spicyPizzaBuilder);
            shop.MakePizza();
            pizza = shop.GetPizza();

            // Must be a Hawaiian Pizza.
            Assert.AreEqual("Spicy", pizza.PizzaType);
        }

        [TestMethod]
        public void PizzaDoughMustBePanBaked()
        {
            PizzaShop shop = new PizzaShop();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            Pizza pizza;

            shop.SetPizzaBuilder(spicyPizzaBuilder);
            shop.MakePizza();
            pizza = shop.GetPizza();

            // Must be a pan baked dough.
            Assert.AreEqual("pan baked", pizza.Dough);
        }

        [TestMethod]
        public void PizzaSauceMustBeHot()
        {
            PizzaShop shop = new PizzaShop();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            Pizza pizza;

            shop.SetPizzaBuilder(spicyPizzaBuilder);
            shop.MakePizza();
            pizza = shop.GetPizza();

            // Must be a hot sauce.
            Assert.AreEqual("hot", pizza.Sauce);
        }
    }
}
