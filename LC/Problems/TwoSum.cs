namespace LC.Problems
{
	//1. Two Sum
	public static class TwoSum
	{
		public static int[] TwoSums(int[] nums, int target)
		{
			var dict = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int remain = target - nums[i];
				if (dict.ContainsKey(remain))
				{
					return new int[] { dict[remain], i };
				}

				dict[nums[i]] = i;
			}

			return new int[0];
		}
	}
}
