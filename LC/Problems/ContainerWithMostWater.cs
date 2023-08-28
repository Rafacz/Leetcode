namespace LC.Problems
{
	//11. Container With Most Water
	public class ContainerWithMostWater
	{
		public static int MaxArea(int[] height)
		{
			if (height.Length == 2)
			{
				return Math.Min(height[0], height[1]);
			}

			int max1 = 0, max2 = 0, area, maxArea = 0;

			for (int x = 0; x < height.Length; x++)
			{
				if (height[x] > max1)
				{
					max1 = height[x];
					max2 = 0;
					for (int y = height.Length - 1; y > x; y--)
					{
						if (height[y] > max2)
						{
							max2 = height[y];
							area = Math.Min(height[x], height[y]) * (y - x);
							if (area > maxArea)
							{
								maxArea = area;
							}
						}
					}
				}

			}
			return maxArea;
		}
	}
}
