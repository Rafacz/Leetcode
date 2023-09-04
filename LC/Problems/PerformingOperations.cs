namespace LC.Problems
{
	//2011. Final Value of Variable After Performing Operations
	public static class PerformingOperations
	{
		public static int FinalValueAfterOperations(string[] operations)
		{
			int result = default;

			foreach (var operation in operations)
			{
				if (operation[1] == '-')
				{
					result--;
				}
				else
				{
					result++;
				}
			}

			return result;
		}
	}
}
