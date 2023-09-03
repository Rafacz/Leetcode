namespace LC.Problems
{
	public static class LongestConsecutiveSequence
	{
		public static int LongestConsecutive(int[] nums)
		{
			if (nums == null || nums.Length == 0) return 0;

			var hs = new HashSet<int>(nums);

			int result = 1;
			int max = 1;

			foreach (var val in hs)
			{
				int num = val;
				while (true)
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
							max = 1;
						}
						max = 1;
						break;
					}
				}
			}

			return result;
		}
	}
}
