using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string entrada = Console.ReadLine();
            string[] entradaArray = entrada.Split();
            int N = int.Parse(entradaArray[0]);

            while(N != 0)
            {
                string[] elementosArray = new string[N];
                for (int i = 1; i < entradaArray.Length; i++)
                {
                    elementosArray[i - 1] = entradaArray[i];
                }

                int[] valores = Array.ConvertAll(elementosArray, s => int.Parse(s));

                OrdenadorBS ordenador = new OrdenadorBS(valores);
                ordenador.Ordenar();
                string vencedor;
                vencedor = ordenador.Trocas % 2 == 0 ? "Carlos" : "Marcelo";
                Console.WriteLine(vencedor);

                entrada = Console.ReadLine();
                entradaArray = entrada.Split();
                N = int.Parse(entradaArray[0]);
            }
        }
    }

    class OrdenadorBS
    {
        public int Trocas = 0;
        public int[] Elementos;
        public OrdenadorBS(int[] v)
        {
            Elementos = v;
        }
        public void Ordenar()
        {
            for(int i = Elementos.Length - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (Elementos[j] > Elementos[j + 1])
                    {
                        Troca(j, j + 1);
                        Trocas++;
                    }
                }
            } 
        }
        public void Troca(int indiceA, int indiceB)
        {
            int aux = Elementos[indiceA];
            Elementos[indiceA] = Elementos[indiceB];
            Elementos[indiceB] = aux;
        }
        public override string ToString()
        {
            return String.Join(" ",Array.ConvertAll(Elementos, i => i.ToString()));
        }
    }
}