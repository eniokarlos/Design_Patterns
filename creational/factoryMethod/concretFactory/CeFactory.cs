namespace factoryMethod
{
    public class CeFactory : PizzaFactoryMethod
    {
        private static Dictionary<int, Func<Pizza>> Factories = new Dictionary<int, Func<Pizza>>
        {
            {1, () => new CeCheese()},
            {2, () => new CeMozzarella()}
        };
        protected override Pizza CreatePizza(int type)
        {
            var factory = Factories[type];
            return factory();
        }
    }
}