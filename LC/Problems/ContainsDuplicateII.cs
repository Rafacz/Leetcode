namespace LC.Problems
{
	//219. Contains Duplicate II
	public static class ContainsDuplicateII
	{
		public static bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (j - i > k)
					{
						break;
					}

					if (nums[i] == nums[j])
					{
						return true;
					}
				}
			}

			return false;
		}
	}
}
