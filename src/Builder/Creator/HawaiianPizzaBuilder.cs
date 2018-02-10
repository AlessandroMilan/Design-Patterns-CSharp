namespace Builder.Creator
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public HawaiianPizzaBuilder()
        {
            PizzaType = "Hawaiian";
        }

        public override void SetDough()
        {
            Pizza.SetDough("cross");
        }

        public override void SetSauce()
        {
            Pizza.SetSauce("mild");
        }

        public override void SetTopping()
        {
            Pizza.SetTopping("ham+pineapple");
        }
    }
}
