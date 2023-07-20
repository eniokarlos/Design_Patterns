namespace abstractFactory
{
    public class HyundaiFactory : IMounter
    {
        public ISedan CreateSedan()
        {
            return new HB20Hyundai();
        }

        public ISuv CreateSuv()
        {
            return new CretaHyundai();
        }
    }
}