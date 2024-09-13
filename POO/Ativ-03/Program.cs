class Program
{
    static int[] OrdenarVetor(int[] vetor)
    {
        int n = vetor.Length;
        int[] vetorOrdenado = (int[])vetor.Clone(); 

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (vetorOrdenado[j] > vetorOrdenado[j + 1])
                {
                    int temp = vetorOrdenado[j];
                    vetorOrdenado[j] = vetorOrdenado[j + 1];
                    vetorOrdenado[j + 1] = temp;
                }
            }
        }

        return vetorOrdenado;
    }

    static void Main()
    {
        Console.Write("Digite o número de elementos no vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o elemento " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int[] vetorOrdenado = OrdenarVetor(vetor);
        Console.Write("Vetor Ordenado: { ");
        for (int i = 0; i < vetorOrdenado.Length; i++)
        {
            Console.Write(vetorOrdenado[i]);
            if (i < vetorOrdenado.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" }");
    }
}
