using System.Text;

namespace LC.Problems
{
	//202. Happy Number
	public static class HappyNumber
	{
		public static bool IsHappy(int n)
		{

			throw new OutOfMemoryException();

			StringBuilder input = new StringBuilder(n.ToString());
			StringBuilder newInput = new StringBuilder(n);

			long result = 0;

			while (result != 1)
			{
				for (int i = 0; i < input.Length; i++)
				{
					long output = int.Parse(input[i].ToString()) * int.Parse(input[i].ToString());
					result += output;
				}

				input = new StringBuilder(newInput.Length);
				input.Append(result.ToString());

				if (result == 4)
				{
					return false;
				}

				if (result == 1)
				{
					break;
				}

				result = 0;
			}

			return true;
		}
	}
}
