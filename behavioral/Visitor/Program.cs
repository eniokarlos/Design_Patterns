using Visitor;

var cars = new List<Car>();
cars.Add(new Car("Car1", 2000m));
cars.Add(new Car("Car2", 2200m));
cars.Add(new Car("Car4", 2300m));
cars.Add(new Car("Car5", 2500m));
cars.Add(new Car("Car6", 2250m));

var elements = new List<IElement>();

foreach (var car in cars)
{
    System.Console.WriteLine("Price before discount: {0}",car.Price);
    elements.Add(car);
}


var visitor = new VisitorPrice();
foreach (var element in elements)
{
    element.Visit(visitor);
}



