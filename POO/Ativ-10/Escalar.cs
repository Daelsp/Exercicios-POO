namespace Ativ10
{
	public static class VetorOperations
	{
		public static int ProdutoEscalar(int[] vetor1, int[] vetor2)
		{
			if (vetor1.Length != vetor2.Length)
				throw new ArgumentException("Os vetores devem ter a mesma dimensão.");

			int produtoEscalar = 0;

			for (int i = 0; i < vetor1.Length; i++)
			{
				produtoEscalar += vetor1[i] * vetor2[i];
			}

			return produtoEscalar;
		}
	}
}
