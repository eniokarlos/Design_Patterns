using composite;

Employee Thiago = new Employee(1,"Thiago");
Employee Gabriel = new Employee(2, "Gabriel");
Employee Jones = new Employee(3, "Jones");

Thiago.AddSubordinate(Gabriel);
Thiago.AddSubordinate(Jones);

Employee Barbara = new Employee(4, "Barbara");
Employee Andre = new Employee(7, "Andre");
Employee Cesar = new Employee(5, "Cesar");

Gabriel.AddSubordinate(Barbara);
Gabriel.AddSubordinate(Andre);

Contractor John = new Contractor(6, "John");

Jones.AddSubordinate(Cesar);
Jones.AddSubordinate(John);


foreach(Employee manager in Thiago.Subordinates)
{
    Console.WriteLine($"\n EmpID={manager.Id}, Name={manager.Name}");

    foreach(var employee in manager.Subordinates)
    {
        Console.WriteLine($" \t EmpID={employee.Id}, Name={employee.Name}");
    }
}