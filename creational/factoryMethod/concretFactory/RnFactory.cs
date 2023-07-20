namespace factoryMethod
{
    public class RnFactory : PizzaFactoryMethod
    {
        private static Dictionary<int, Func<Pizza>> Factories = new Dictionary<int, Func<Pizza>>
        {
            {1, () => new RnCheese()},
            {2, () => new RnMozzarella()}
        };
        protected override Pizza CreatePizza(int type)
        {
            var factory = Factories[type];
            return factory();
        }

    }
}