using System;

class MergeSort
{

    public int Trocas = 0;
    void Merge(int[] arr, int l, int m, int r)
    {

        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

        i = 0;
        j = 0;

        
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
                Trocas += n1 - i;
            }
            k++;
        }

        
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

      
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

  
    void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
           
            Sort(arr, l, m);
            Sort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }
    }

    public static void Main(String[] args)
    {
        string entrada = Console.ReadLine();
        string[] entradaArray = entrada.Split();
        int N = int.Parse(entradaArray[0]);

        while (N != 0)
        {
            string[] elementosArray = new string[N];
            for (int i = 1; i < entradaArray.Length; i++)
            {
                elementosArray[i - 1] = entradaArray[i];
            }

            int[] valores = Array.ConvertAll(elementosArray, s => int.Parse(s));

            MergeSort ordenator = new MergeSort();
            ordenator.Sort(valores, 0, valores.Length - 1);
            string vencedor;
            vencedor = ordenator.Trocas % 2 == 0 ? "Carlos" : "Marcelo";
            Console.WriteLine(vencedor);

            entrada = Console.ReadLine();
            entradaArray = entrada.Split();
            N = int.Parse(entradaArray[0]);
           
        }
    }
}