namespace LC.Problems
{
	//202. Happy Number
	public static class HappyNumber
	{
		public static bool IsHappy(int n)
		{
			var hs = new HashSet<int>();

			while (n != 1)
			{
				if (hs.Contains(n))
				{
					return false;
				}

				hs.Add(n);
				n = n.ToString().Select(x => int.Parse(x.ToString())).Sum(x => x * x);
			}

			return true;
		}
	}
}
