namespace factoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        protected abstract Pizza CreatePizza(int type);
        public Pizza Create(int type)
        {
            var pizza = CreatePizza(type);
            return pizza;
        }
    }
}