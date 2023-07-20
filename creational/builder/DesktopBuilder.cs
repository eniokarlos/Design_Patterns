namespace builder
{
    public class DesktopBuilder : ComputerBuilder
    {
        Computer Computer;
        public DesktopBuilder()
        {
            Computer = new Computer("Desktop");
        }

        public override void Devices()
        {
            System.Console.WriteLine("Devices builded on Desktop... ");
        }

        public override void Os()
        {
            System.Console.WriteLine("Os Builded on Desktop... ");
        }

        public Computer ComputerType
        {
            get{return Computer;}
        }
    }
}