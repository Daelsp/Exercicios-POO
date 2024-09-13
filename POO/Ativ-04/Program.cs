using System;

class Program
{
    static (double media, double desvioPadrao) CalcularMediaDesvioPadrao(int[] vetor)
    {
        if (vetor.Length == 0)
            throw new ArgumentException("O vetor não pode estar vazio.");

        double soma = 0;
        foreach (int valor in vetor)
        {
            soma += valor;
        }

        double media = soma / vetor.Length;

        double somaQuadrados = 0;
        foreach (int valor in vetor)
        {
            somaQuadrados += (valor - media) * (valor - media);
        }

        double desvioPadrao = Math.Sqrt(somaQuadrados / vetor.Length);

        return (media, desvioPadrao);
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

        var (media, desvioPadrao) = CalcularMediaDesvioPadrao(vetor);
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Desvio Padrão: {desvioPadrao:F2}");
    }
}
