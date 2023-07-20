using decorator;

Person p1 = new Person();

System.Console.WriteLine("Using Person");
System.Console.WriteLine(p1.Walk());

FastPersonDecorator decorator = new FastPersonDecorator(p1);

System.Console.WriteLine("Using Decorator");
System.Console.WriteLine(decorator.Walk());
System.Console.WriteLine(decorator.Run());