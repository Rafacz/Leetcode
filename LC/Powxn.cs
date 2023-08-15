namespace LC
{
	//50. Pow(x, n)
	public class Powxn
	{
		public static double MyPow(double x, int n)
		{
			if (n == 0) return 1;

			long d = n;

			if (d < 0)
			{
				x = 1 / x;
				d = -d;
			}

			double result = 1;
			double current = x;

			while (d > 0)
			{
				if (d % 2 == 1)
				{
					result *= current;
				}

				current *= current;
				d /= 2;
			}

			return result;
		}
	}
}
