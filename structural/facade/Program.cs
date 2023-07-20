using facade;

Subsystem1 s1 = new Subsystem1();
Subsystem2 s2 = new Subsystem2();
Facade facade = new Facade(s1, s2);

Client.ClientCode(facade);

