namespace LC
{
	//1929. Concatenation of Array
	public class ConcatenationOfArray
	{
		public static int[] GetConcatenation(int[] nums)
		{
			if (nums is null || nums.Length == 0)
			{
				return nums;
			}

			Array.Resize(ref nums, nums.Length * 2);

			for (int i = 0; i < nums.Length / 2; i++)
			{
				nums[i + (nums.Length / 2)] = nums[i];
			}

			return nums;
		}
	}
}
