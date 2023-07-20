using Observer;

Group SchoolGroup = new Group("School Group");
Group WorkGroup = new Group("Work Group");
User u1 = new User("John");
User u2 = new User("Mary");
User u3 = new User("Elizabeth");
User u4 = new User("Carl");

SchoolGroup.Subscribe(u1);
SchoolGroup.Subscribe(u2);
WorkGroup.Subscribe(u3);
WorkGroup.Subscribe(u4);

SchoolGroup.SendMessage("Hi! Teacher will come in Monday");
WorkGroup.SendMessage("Time To Work!");

WorkGroup.Unsubscribe(u3);
WorkGroup.SendMessage("Vacation!!!");
