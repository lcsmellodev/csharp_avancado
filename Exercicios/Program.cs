/*A dona de um pensionato possui dez quartos para alugar para estudantes,
    sendo esses quartos identificados pelos números 0 a 9.
    Quando um estudante deseja alugar um quarto, deve-se registrar o nome
    e email deste estudante.
    Fazer um programa que inicie com todos os dez quartos vazios, e depois
    leia uma quantidade N representando o número de estudantes que vão
    alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
    N estudantes. Para cada registro de aluguel, informar o nome e email do
    estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
    que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
    um relatório de todas ocupações do pensionato, por ordem de quarto,
    conforme exemplo

    Quantos quartos serão alugados? 3
    Aluguel #1:
    Nome: Maria Green
    Email: maria@gmail.com
    Quarto: 5
    Aluguel #2:
    Nome: Marco Antonio
    Email: marco@gmail.com
    Quarto: 1
    Aluguel #3:
    Nome: Alex Brown
    Email: alex@gmail.com
    Quarto: 8
    Quartos ocupados:
    1: Marco Antonio, marco@gmail.com
    5: Maria Green, maria@gmail.com
    8: Alex Brown, alex@gmail.com
*/

using Exercicios;

Console.Write("Quantos quartos serão alugados?");
int num_quartos = int.Parse(Console.ReadLine());
Quarto[] q = new Quarto[10];

//for(int i = 0; i < 10; i++)
//{
//    q[i] = new Quarto();
    
//}

for(int i = 0; i < num_quartos; i++)
{

    string nome, email;
    int quarto;

    Console.WriteLine($"Aluguel #{i + 1}");
    Console.Write("Nome : ");
    nome = Console.ReadLine();
    Console.Write("Email : ");
    email = Console.ReadLine();
    Console.Write("Quarto : ");
    quarto = int.Parse(Console.ReadLine());

    q[quarto] = new Quarto();

    q[quarto].Nome = nome;
    q[quarto].Email = email;

    

    Console.WriteLine(" ");

}

Console.WriteLine("Quartos ocupados:");
for(int i = 0; i < 10; i++)
{
    if (q[i] != null)
    {
        Console.WriteLine($"{i}: {q[i].Nome}, {q[i].Email}");

    }
}




