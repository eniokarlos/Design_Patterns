namespace builder
{
    public abstract class ComputerBuilder
    {
        public abstract void Os();
        public abstract void Devices();
        Computer ComputerType{get;}
    }
}