namespace Builder.Product
{
    public class Pizza
    {
        public string PizzaType { get; private set; }
        public string Dough { get; private set; }
        public string Sauce { get; private set; }
        public string Topping { get; private set; }

        public Pizza(string pizzaType)
        {
            PizzaType = pizzaType;
        }

        internal void SetDough(string dough)
        {
            Dough = dough;
        }

        internal void SetSauce(string sauce)
        {
            Sauce = sauce;
        }

        internal void SetTopping(string topping)
        {
            Topping = topping;
        }
    }
}
