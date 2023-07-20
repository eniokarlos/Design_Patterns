using Mediator;

GroupMediator group = new GroupMediator();
User user1 = new ConcreteUser(group, "Carl");
User user2 = new ConcreteUser(group, "Mary");
User user3 = new ConcreteUser(group, "John");
User user4 = new ConcreteUser(group, "Smith");

group.RegisterUser(user1);
group.RegisterUser(user2);
group.RegisterUser(user3);
group.RegisterUser(user4);

user1.Send("Have you heard about Mediator Pattern?");
user2.Send("No, where i can find it?");
user1.Send("It's on Gof book");




