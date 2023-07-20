namespace abstractFactory
{
    public interface IMounter
    {
        ISuv CreateSuv();
        ISedan CreateSedan();   
    }
}