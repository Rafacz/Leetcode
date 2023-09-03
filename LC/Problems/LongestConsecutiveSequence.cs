namespace LC.Problems
{
	public static class LongestConsecutiveSequence
	{
		public static int LongestConsecutive(int[] nums)
		{
			if (nums == null || nums.Length == 0) return 0;

			var hs = new HashSet<int>(nums);

			int num = hs.Min();
			int highest = hs.Max();
			int max = 1;

			int result = default;

			while (num <= highest)
			{
				if (hs.Contains(num = num + 1))
				{
					max++;
				}
				else
				{
					if (max > result)
					{
						result = max;
						if (result > nums.Length / 2)
						{
							return result;
						}
					}
					max = 0;
				}
			}

			return result;
		}
	}
}
