using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    internal class Ordenator
    {
        int[] Entrada;

        public Ordenator(int[] entrada)
        {
            Entrada = entrada;
        }

        internal int[] InsertionSort()
        {
            int i, j;
            int N = Entrada.Length;
            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && Entrada[i] < Entrada[i - 1]; i--)
                {
                    int[] iteracao = TrocarValores(i, i - 1);
                    PrintArray(iteracao);
                }
            }
            return Entrada;
        }

        internal int[] TrocarValores(int m, int n)
        {
            int temp;
            temp = Entrada[m];
            Entrada[m] = Entrada[n];
            Entrada[n] = temp;
            return Entrada;
        }

        internal void PrintArray(int[] array)
        {
            Console.WriteLine();
            foreach (int numero in array)
            {
                Console.Write($"{numero} ");
            }
        }
    }
}
