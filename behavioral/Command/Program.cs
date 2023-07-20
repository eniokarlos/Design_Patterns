using Command;

Invoker modifyPrice = new Invoker();
Product p1 = new Product("Pc", 1500);
modifyPrice.Invoke(IncreaseProductPriceCommand.Of(p1, 500));
modifyPrice.Invoke(IncreaseProductPriceCommand.Of(p1, 200));
modifyPrice.Invoke(DecreaseProductPriceCommand.Of(p1, 300));


System.Console.WriteLine(p1.ToString());

modifyPrice.Undo();
modifyPrice.Undo();
modifyPrice.Undo();

System.Console.WriteLine(p1.ToString());
