namespace LC.Arrays
{
	public static class ContainsDuplicate
	{
		//217. Contains Duplicate
		public static bool ContainsDuplicates(int[] nums)
		{
			var hs = new HashSet<int>(nums.Length);

			for (int i = 0; i < nums.Length; i++)
			{
				if (hs.Contains(nums[i])) return true;
				hs.Add(nums[i]);
			}

			return false;
		}
	}
}
