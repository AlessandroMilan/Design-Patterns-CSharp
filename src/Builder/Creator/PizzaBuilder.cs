using Builder.Product;

namespace Builder.Creator
{
    public abstract class PizzaBuilder
    {
        protected Pizza Pizza;
        protected string PizzaType;

        public abstract void SetDough();
        public abstract void SetSauce();
        public abstract void SetTopping();

        public void CreateNewPizzaProduct()
        {
            Pizza = new Pizza(PizzaType);
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }
    }
}
