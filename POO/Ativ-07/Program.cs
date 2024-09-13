class Programa
{
    static void Main()
    {
        int[] vetor = { 1, 2, 2, 3, 4, 4, 5 };
        int[] vetorSemDuplicados = RemoverDuplicados.Remover(vetor);
        Console.WriteLine("Vetor sem Duplicados: { " + string.Join(", ", vetorSemDuplicados) + " }");
    }
}
