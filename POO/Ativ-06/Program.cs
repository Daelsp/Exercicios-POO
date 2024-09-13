namespace Ativ06
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o número de elementos no vetor1: ");
            int tamanho1 = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[tamanho1];
            for (int i = 0; i < tamanho1; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " de vetor1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o número de elementos no vetor2: ");
            int tamanho2 = int.Parse(Console.ReadLine());

            int[] vetor2 = new int[tamanho2];
            for (int i = 0; i < tamanho2; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " de vetor2: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            int[] vetorIntercalado = VetorOperations.IntercalarVetores(vetor1, vetor2);

            Console.Write("Vetor Intercalado: { ");
            for (int i = 0; i < vetorIntercalado.Length; i++)
            {
                Console.Write(vetorIntercalado[i]);
                if (i < vetorIntercalado.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");
        }
    }
}
