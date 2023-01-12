// See https://aka.ms/new-console-template for more information

using ExercicioContaBancaria;
using System.Globalization;

int numero;

string titular;
double saldoInicial;
double saldo;
string resposta;



Console.WriteLine("Entre com o numero da conta :");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o titular da conta :");
titular = Console.ReadLine();


Console.WriteLine("Haverá depósito inicial? s/n");
resposta = Console.ReadLine();

if (resposta == "s")
{
    Console.WriteLine("Entre com o valor do depósito inicial");
    saldoInicial = int.Parse(Console.ReadLine());


}
else
{
    saldoInicial = 0;
}

Conta c = new Conta(numero, titular, saldoInicial);

Console.WriteLine(c.ToString());
Console.WriteLine($"Entre com um valor para depósito");

double x = double.Parse(Console.ReadLine());

c.Deposito(x);

Console.WriteLine(c.ToString());
Console.WriteLine($"Entre com um valor para saque :");

x = double.Parse(Console.ReadLine());

c.Saque(x);

Console.WriteLine(c.ToString());











