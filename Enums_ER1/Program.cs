//Exercicio sobre composicao de objetos

using Enums_ER1.Entities;
using Enums_ER1.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string department = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name:");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
string level = Console.ReadLine();
Console.Write("Base Salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("How many contracts yo this worker?");
int contracts_number = int.Parse(Console.ReadLine());

Department dpt = new Department(department);
Worker worker = new Worker(name, Enum.Parse<WorkLevel>(level) , salary, dpt);

List<HourContract> contracts = new List<HourContract>();

for(int i = 0; i < contracts_number; i++)
{
    Console.WriteLine($"Enter #{i + 1} contract data:");
    Console.Write("Date (DD/MM/YYY): ");
    string date =  Console.ReadLine();
    DateTime dateTime = DateTime.Parse(date);
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int duration = int.Parse(Console.ReadLine());

    worker.Contracts = contracts;
    worker.AddContract(new HourContract(dateTime, valuePerHour, duration));
    
}

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string incomeData = Console.ReadLine();
double income = worker.Income(DateTime.ParseExact(incomeData, "MM/yyyy",CultureInfo.InvariantCulture).Year, DateTime.ParseExact(incomeData, "MM/yyyy", CultureInfo.InvariantCulture).Month);
Console.WriteLine(worker);
Console.WriteLine($"Income for {incomeData}: {income}");


