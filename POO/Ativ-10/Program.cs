namespace Ativ10
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o número de elementos nos vetores: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];

            Console.WriteLine("Digite os elementos do vetor1:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor2:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            try
            {
                int produtoEscalar = VetorOperations.ProdutoEscalar(vetor1, vetor2);
                Console.WriteLine("Produto Escalar: " + produtoEscalar);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
