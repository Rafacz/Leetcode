namespace LC.Problems
{
	//69. Sqrt(x)
	public class Sqrtx
	{
		public static int MySqrt(int x)
		{
			if (x == 0 || x == 1) return x;
			if (x == 2 || x == 3) return 1;

			for (long y = 1; y < x; y++)
			{
				if (y * y > x)
				{
					return (int)(y - 1);
				}
			}

			return 0;
		}
	}
}
