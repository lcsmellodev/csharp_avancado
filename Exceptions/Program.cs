using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial Balance: ");
double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw Limit: ");
double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, initialBalance, withDrawLimit);
try
{
    acc.WithDraw(amount);
    Console.WriteLine(acc);

}

catch (InsufficientBalanceException ibe)
{
    Console.WriteLine("Withdraw error: " + ibe.Message);
}
catch (WithDrawLimitException wle)
{
    Console.WriteLine("Withdraw error: " + wle.Message);
}

