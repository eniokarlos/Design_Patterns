namespace prototype
{
    public class Soldier : ICloneable
    {
        public string Name {get;set;}
        public string Weapon {get;set;}
        public Gadget Gadget {get;set;}
        
        public Soldier()
        {}
        public Soldier(Soldier soldier)
        {
            this.Name = soldier.Name;
            this.Weapon = soldier.Weapon;
            this.Gadget = soldier.Gadget;
        }

        public object Clone()
        {
            //deep copy
            Soldier soldier = (Soldier)this.MemberwiseClone();
            soldier.Gadget = this.Gadget.Clone();
            return soldier;
        }
    }
}