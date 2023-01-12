using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionarios
{
    internal class Empregado
    {
        public double Salario  { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }

        public void AumentarSalario(double porcentagem)
        {
            Salario+=Salario*porcentagem;
        }

        public override string ToString()
        {
            return $"\n {this.Id}, {this.Nome}, {this.Salario}";
        }

    }
}
