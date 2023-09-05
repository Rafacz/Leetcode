namespace LC.Problems
{
	public static class LongestConsecutiveSequence
	{
		public static int LongestConsecutive(int[] nums)
		{
			var items = new HashSet<int>(nums);

			var result = 0;
			var used = new HashSet<int>();
			foreach (var item in items)
			{
				if (used.Contains(item)) { continue; }

				var current = item;
				var length = 1;
				used.Add(current);

				while (items.Contains(current - 1))
				{
					length++;
					used.Add(current - 1);
					current--;
				}

				current = item;
				while (items.Contains(current + 1))
				{
					length++;
					used.Add(current + 1);
					current++;
				}

				if (length > result)
				{
					result = length;
				}
			}

			return result;
		}
	}
}
