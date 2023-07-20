using Memento1;

Client c1 = new Client("User1", 2000);

CareTaker careTaker = new CareTaker(c1.SaveMemento());

c1.Name = "User2";
c1.Budget = 1500;

System.Console.WriteLine(c1.ToString());

c1.RestoreMemento(careTaker.Memento);

System.Console.WriteLine(c1.ToString());
