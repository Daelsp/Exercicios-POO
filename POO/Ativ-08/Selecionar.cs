namespace Ativ08
{
    public static class VetorOperations
    {
        public static int ContarElementos(int[] vetor, int x)
        {
            int contagem = 0;
            foreach (int elemento in vetor)
            {
                if (elemento == x)
                {
                    contagem++;
                }
            }
            return contagem;
        }
    }
}
