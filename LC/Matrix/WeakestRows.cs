namespace LC.Matrix
{
	//1337. The K Weakest Rows in a Matrix
	public static class WeakestRows
	{
		public static int[] KWeakestRows(int[][] mat, int k)
		{
			var result = new HashSet<int>(k);
			int rows = mat.GetLength(0);
			int cols = mat[0].GetLength(0);

			int p = 0;

			for (int y = 0; y < cols; y++)
			{
				for (int x = 0; x < rows; x++)
				{
					if (mat[x][y] == 0 && !result.Contains(x))
					{
						result.Add(x);
						p++;

						if (p == k)
						{
							return result.ToArray();
						}
					}
				}
			}

			if (p == 0)
			{
				return new int[] { 0 };
			}

			if (result.Count != k)
			{
				for (int x = 0; x < rows; x++)
				{
					result.Add(x);
					if (result.Count == k)
					{
						return result.ToArray();
					}
				}
			}

			return result.ToArray();
		}
	}
}
