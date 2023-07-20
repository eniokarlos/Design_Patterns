namespace prototype
{
    public class Gadget
    {
        public string Name;

        public Gadget(string name)
        {
            this.Name = name;
        }

        public Gadget Clone()
        {
            
            return (Gadget)this.MemberwiseClone();
        }
    }
}