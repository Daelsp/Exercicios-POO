public class RemoverDuplicados
{
    public static int[] Remover(int[] vetor)
    {
        int n = vetor.Length;
        int[] resultado = new int[n];
        int contador = 0;

        for (int i = 0; i < n; i++)
        {
            bool ehDuplicado = false;

            for (int j = 0; j < contador; j++)
            {
                if (resultado[j] == vetor[i])
                {
                    ehDuplicado = true;
                    break;
                }
            }

            if (!ehDuplicado)
            {
                resultado[contador++] = vetor[i];
            }
        }

        Array.Resize(ref resultado, contador);
        return resultado;
    }
}
