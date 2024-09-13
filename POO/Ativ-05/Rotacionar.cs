namespace Ativ05
{
    public static class VetorOperations
    {
        public static int[] RotacionarVetor(int[] vetor, int n)
        {
            int tamanho = vetor.Length;
            if (tamanho == 0)
                return vetor;

            n = n % tamanho;
            if (n < 0)
                n += tamanho;

            int[] vetorRotacionado = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                int novaPosicao = (i + n) % tamanho;
                vetorRotacionado[novaPosicao] = vetor[i];
            }

            return vetorRotacionado;
        }
    }
}
