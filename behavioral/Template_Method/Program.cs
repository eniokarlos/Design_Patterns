using Template_Method;

var debitCard = new DebitCardPayment();
var creditCard = new CreditCardPayment();

debitCard.Process();
System.Console.WriteLine("\n");
creditCard.Process();