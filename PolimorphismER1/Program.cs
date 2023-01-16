using PolimorphismER1.Entities;
using System.Globalization;


List<Employee> emps = new List<Employee>();
Console.Write("Enter the number of Employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Employee #{i + 1} data: ");
    Console.Write("Outsourced (y/n)?");
    string answer = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value Per Hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (answer == "Y" || answer == "y")
    {
        Console.Write("Additional Charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        emps.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else if (answer == "N" || answer == "n")
    {
        emps.Add(new Employee(name, hours, valuePerHour));
    }
}

    Console.WriteLine("PAYMENTS:");
    foreach(Employee item in emps)
    {
        Console.WriteLine(item);
    }






