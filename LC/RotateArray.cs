namespace LC
{
	//189. Rotate Array
	public static class RotateArray
	{
		public static void Rotate(int[] nums, int k)
		{
			if (k > nums.Length)
			{
				k = k % nums.Length;
			}

			Reverse(ref nums, 0, nums.Length - k - 1);
			Reverse(ref nums, nums.Length - k, nums.Length - 1);
			Reverse(ref nums, 0, nums.Length - 1);
		}

		private static void Reverse(ref int[] nums, int from, int to)
		{
			for (int i = from; i < to; i++)
			{
				int temp = nums[i];
				nums[i] = nums[to];
				nums[to] = temp;
				to--;
			}
		}
	}
}
