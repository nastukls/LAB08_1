using LAB08_1;

Department department = new Department("IT Department");
Worker w1 = new Worker(
 "Guiseppe Leonardi",
 new DateTime(1990, 6, 12),
 new DateTime(2013, 5, 6),
 23
);
Worker w2 = new Worker(
 "Worker 2",
 new DateTime(1980, 6, 12),
 new DateTime(2018, 5, 6),
 15
);
Programmer p1 = new Programmer(
 "Alison Krause",
 new DateTime(1990, 6, 12),
 new DateTime(2013, 5, 6),
 Level.MIDDLE
);
Programmer p2 = new Programmer(
 "Alex Dunlop",
 new DateTime(1995, 3, 12),
 new DateTime(2019, 5, 6),
 Level.SENIOR
 );
Manager m1 = new Manager(
 "Ritchy Mitchell",
 new DateTime(1995, 3, 12),
 new DateTime(2019, 5, 6),
 12,
 true
);

department.AddEmployee(w1);
department.AddEmployee(w2);
department.AddEmployee(p1);
department.AddEmployee(p2);
department.AddEmployee(m1);

department.PrintEmployees();

Console.WriteLine(department.AddEmployee(w1));


Employee? found = department.FindEmployee(w1.ID);

if (found != null)
{
    Console.WriteLine(found);
}
else
{
    Console.WriteLine("Employee not found");
}

Console.WriteLine($"Total employees:{ department.CountEmployees()}");
Console.WriteLine($"Workers: {department.CountWorkers()}");
Console.WriteLine($"Programmers:{ department.CountProgrammers()}");
Console.WriteLine($"Managers: {department.CountManagers()}");
Console.WriteLine($"Total salary:{ department.CalculateTotalSalary()}");
Console.WriteLine($"Average salary:{ department.CalculateAverageSalary()}");
Console.WriteLine($"Highest paid:{ department.FindHighestPaidEmployee()}");
Console.WriteLine($"Lowest paid:{ department.FindLowestPaidEmployee()}");

department.RemoveEmployee(p1.ID);
Console.WriteLine("After removal:");
department.PrintEmployees();
Console.WriteLine($"Total employees:{ department.CountEmployees()}");
Console.WriteLine($"Average salary:{ department.CalculateAverageSalary()}");

Department emptyDepartment = new Department("Empty Department");

Console.WriteLine($"Total employees: {emptyDepartment.CountEmployees()}");
Console.WriteLine($"Average salary: {emptyDepartment.CalculateAverageSalary()}");
Console.WriteLine($"Highest paid: {emptyDepartment.FindHighestPaidEmployee()}");
Console.WriteLine($"Lowest paid: {emptyDepartment.FindLowestPaidEmployee()}");