class Program
{
    static (int maior, int menor) EncontrarExtremos(int[] vetor)
    {
        if (vetor.Length == 0)
            throw new ArgumentException("O vetor não pode estar vazio.");

        int maior = vetor[0];
        int menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
                maior = vetor[i];
            if (vetor[i] < menor)
                menor = vetor[i];
        }

        return (maior, menor);
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

        var (maior, menor) = EncontrarExtremos(vetor);
        Console.WriteLine("Maior: " + maior);
        Console.WriteLine("Menor: " + menor);
    }
}
