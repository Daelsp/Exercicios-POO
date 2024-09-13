namespace Ativ01
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

            int resultado = VetorOperations.SomarElementos(vetor);
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
