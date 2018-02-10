using Builder.Creator;
using Builder.Product;

namespace Builder.Director
{
    public class PizzaShop
    {
        private PizzaBuilder Builder;

        public void SetPizzaBuilder(PizzaBuilder builder)
        {
            Builder = builder;
        }

        public void MakePizza()
        {
            Builder.CreateNewPizzaProduct();
            Builder.SetDough();
            Builder.SetSauce();
            Builder.SetTopping();
        }

        public Pizza GetPizza()
        {
            return Builder.GetPizza();
        }
    }
}
