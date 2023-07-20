using abstractFactory;

IMounter factory = new HyundaiFactory();
ISedan sedan = factory.CreateSedan();
ISuv suv = factory.CreateSuv();

Client client = new Client(suv, sedan);

client.GetSedan();
client.GetSuv();