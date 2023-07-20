namespace builder
{
    public class Director
    {
        public void Build(ComputerBuilder computerBuilder)
        {
            computerBuilder.Devices();
            computerBuilder.Os();
        }
    }
}