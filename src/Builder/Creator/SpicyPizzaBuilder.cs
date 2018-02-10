namespace Builder.Creator
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public SpicyPizzaBuilder()
        {
            PizzaType = "Spicy";
        }
        public override void SetDough()
        {
            Pizza.SetDough("pan baked");
        }

        public override void SetSauce()
        {
            Pizza.SetSauce("hot");
        }

        public override void SetTopping()
        {
            Pizza.SetTopping("pepperoni+salami");
        }
    }
}
