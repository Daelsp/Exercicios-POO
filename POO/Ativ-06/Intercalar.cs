namespace Ativ06
{
    public static class VetorOperations
    {
        public static int[] IntercalarVetores(int[] vetor1, int[] vetor2)
        {
            int tamanho1 = vetor1.Length;
            int tamanho2 = vetor2.Length;
            int tamanhoTotal = tamanho1 + tamanho2;
            int[] vetorIntercalado = new int[tamanhoTotal];

            int i = 0, j = 0, k = 0;

            while (i < tamanho1 && j < tamanho2)
            {
                vetorIntercalado[k++] = vetor1[i++];
                vetorIntercalado[k++] = vetor2[j++];
            }

            while (i < tamanho1)
            {
                vetorIntercalado[k++] = vetor1[i++];
            }

            while (j < tamanho2)
            {
                vetorIntercalado[k++] = vetor2[j++];
            }

            return vetorIntercalado;
        }
    }
}
