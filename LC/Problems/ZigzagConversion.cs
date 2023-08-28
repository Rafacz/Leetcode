using System.Text;

namespace LC.Problems
{
	//6. Zigzag Conversion
	public class ZigzagConversion
	{
		public static string Convert(string s, int numRows)
		{
			/*
			 *				PAYPALISHIRING      3 
			 * 
			 *				P A H N
			 *				APLSIIG
			 *				Y I R  
			 *				
			 *				PAHNAPLSIIGYIR
			 */

			var builder = new StringBuilder(s.Length);

			var arr = new char[numRows, s.Length];

			uint x = 0;
			uint y = 0;


			for (int i = 0; i < s.Length; i++)
			{
				arr[x, y] = s[i];

				if (y % 3 == 0)
				{
					x += 1;
				}

				if (y % 3 != 0)
				{
					y -= 1;
				}
			}


			//print 2d arr into the console as matrix
			for (int i = 0; i < numRows; i++)
			{
				for (int j = 0; j < s.Length; j++)
				{
					if (arr[i, j] != '\0')
					{
						builder.Append(arr[i, j]);
					}
				}
			}

			Console.WriteLine(builder.ToString());

			return builder.ToString();
		}
	}
}
