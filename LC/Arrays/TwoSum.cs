namespace LC.Arrays
{
	//1. Two Sum
	public static class TwoSum
	{
		public static int[] TwoSums(int[] nums, int target)
		{
			var dict = new Dictionary<int, int>(nums.Length);

			for (int i = 0; i < nums.Length; i++)
				if (dict.ContainsKey(target - nums[i]))
					return new int[] { dict[target - nums[i]], i };
				else
					dict.TryAdd(nums[i], i);

			return new int[] { };
		}
	}
}
