namespace Ativ09
{
    public static class VetorOperations
    {
        public static bool EhPalindromo(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            while (inicio < fim)
            {
                if (vetor[inicio] != vetor[fim])
                {
                    return false;
                }
                inicio++;
                fim--;
            }

            return true;
        }
    }
}
