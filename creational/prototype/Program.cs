using prototype;

Soldier soldier = new Soldier();
soldier.Name = "Soldier";
soldier.Weapon = "Glock";
soldier.Gadget = new Gadget("Kevlar vest");

Soldier soldier_clone = (Soldier)soldier.Clone();
soldier_clone.Gadget.Name = "Dogtag";

Soldier soldier_clone2 = (Soldier)soldier.Clone();
soldier_clone2.Gadget.Name = "Helmet";

Console.WriteLine("Original object");
Console.WriteLine($"{soldier.Name} - {soldier.Weapon} - {soldier.Gadget.Name}");

Console.WriteLine("Clone 1");
Console.WriteLine($"{soldier_clone.Name} - {soldier_clone.Weapon} - {soldier_clone.Gadget.Name}");

Console.WriteLine("Clone 2");
Console.WriteLine($"{soldier_clone2.Name} - {soldier_clone2.Weapon} - {soldier_clone2.Gadget.Name}");