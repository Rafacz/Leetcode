namespace LC.test.Matrix
{
	public class WeakestRows
	{
		[Fact]
		public void Example1()
		{
			int[][] mat = new int[][] {
			new int[] { 1, 1, 0, 0, 0 },
			new int[] { 1, 1, 1, 1, 0 },
			new int[] { 1, 0, 0, 0, 0 },
			new int[] { 1, 1, 0, 0, 0 },
			new int[] { 1, 1, 1, 1, 1 }
		};
			int k = 3;
			int[] expected = new int[] { 2, 0, 3 };

			int[] result = LC.Matrix.WeakestRows.KWeakestRows(mat, k);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example2()
		{
			int[][] mat = new int[][] {
			new int[] { 1, 0, 0, 0 },
			new int[] { 1, 1, 1, 1 },
			new int[] { 1, 0, 0, 0 },
			new int[] { 1, 0, 0, 0 }
		};
			int k = 2;
			int[] expected = new int[] { 0, 2 };

			int[] result = LC.Matrix.WeakestRows.KWeakestRows(mat, k);

			Assert.Equal(expected, result);
		}


		[Fact]
		public void Example13()
		{
			int[][] mat = new int[][] {
			new int[] { 1, 0 },
			new int[] { 1, 0 },
			new int[] { 1, 0 },
			new int[] { 1, 1 }
		};
			int k = 4;
			int[] expected = new int[] { 0, 1, 2, 3 };

			int[] result = LC.Matrix.WeakestRows.KWeakestRows(mat, k);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Example4()
		{
			int[][] mat = new int[][] {
			new int[] { 1, 1, 0 },
			new int[] { 1, 0, 0 },
			new int[] { 1, 0, 0 },
			new int[] { 1, 1, 1 },
			new int[] { 1, 1, 0 },
			new int[] { 0, 0, 0 }
		};
			int k = 4;
			int[] expected = new int[] { 5, 1, 2, 0 };

			int[] result = LC.Matrix.WeakestRows.KWeakestRows(mat, k);

			Assert.Equal(expected, result);
		}
	}
}
