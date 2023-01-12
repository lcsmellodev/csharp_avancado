
using ListaFuncionarios;

int num_empregados;

List<Empregado> empregados = new List<Empregado>();

Console.Write("Quantos empregados serão registrados? ");
num_empregados = int.Parse(Console.ReadLine());

int i = 0;

for(i = 0; i < num_empregados; i++)
{
    empregados.Add(new Empregado());
}

i = 0;
foreach(Empregado empregado in empregados)
{
    Console.WriteLine("Empregado #" + (i+1).ToString());
    Console.Write("Id: ");
    empregado.Id = int.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    empregado.Nome = Console.ReadLine();

    Console.Write("Salario: ");
    empregado.Salario = double.Parse(Console.ReadLine());
    i++;

}

Console.WriteLine("Entre com o Id do funcionário que terá seu salário aumentado");
int id = int.Parse(Console.ReadLine());

if(empregados.Find(x => x.Id == id) != null)
{
    Empregado empregado = empregados.Find(x => x.Id == id);

    Console.WriteLine("Entre com a porcentagem");
    float porcentagem = float.Parse(Console.ReadLine());

    empregado.AumentarSalario(porcentagem);
 
}
else
{
    Console.WriteLine("Este Id não existe");
}

foreach(Empregado empregado in empregados)
{
    Console.WriteLine(empregado.ToString());
}





