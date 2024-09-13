namespace Ativ01
{
    public static class VetorOperations
    {
        public static int SomarElementos(int[] vetor)
        {
            int soma = 0;
            foreach (int valor in vetor)
            {
                soma += valor;
            }
            return soma;
        }
    }
}
