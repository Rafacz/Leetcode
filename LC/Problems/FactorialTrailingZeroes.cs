namespace LC.Problems
{
	//172. Factorial Trailing Zeroes
	public class FactorialTrailingZeroes
	{
		public static int TrailingZeroes(int n)
		{
			if (n == 0) return 0;

			int result = 0;

			while (n > 0)
			{
				result += n / 5;
				n /= 5;
			}

			return result;
		}
	}
}
