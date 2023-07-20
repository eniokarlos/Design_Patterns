using State;

CashMachine context = new CashMachine();

context.Ejectcard();
context.SetPassword();
context.WithDraw();

context.InsertCard();
context.SetPassword();
context.WithDraw();

context.Ejectcard();
context.WithDraw();