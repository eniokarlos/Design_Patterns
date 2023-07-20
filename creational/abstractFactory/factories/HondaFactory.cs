namespace abstractFactory
{
    public class HondaFactory : IMounter
    {
        public ISedan CreateSedan()
        {
            return new CivicHonda();
        }

        public ISuv CreateSuv()
        {
            return new CRVHonda();
        }
    }
}