namespace Ativ05
{
    class Program
    {
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

            Console.Write("Digite o número de posições para rotação: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetorRotacionado = VetorOperations.RotacionarVetor(vetor, n);

            Console.Write("Vetor Rotacionado: { ");
            for (int i = 0; i < vetorRotacionado.Length; i++)
            {
                Console.Write(vetorRotacionado[i]);
                if (i < vetorRotacionado.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");
        }
    }
}
