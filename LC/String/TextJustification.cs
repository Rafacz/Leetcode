using System.Text;

namespace LC.String
{
	//68. Text Justification
	public static class TextJustification
	{
		public static IList<string> FullJustify(string[] words, int maxWidth)
		{
			var result = new List<string>();
			var sb = new StringBuilder(maxWidth);

			int len = 0;
			int b = -1;
			int p = 0;

			for (int x = 0; x < words.Length; x++)
			{
				len += words[x].Length;
				b++;

				if (len + b >= maxWidth || x == words.Length - 1)
				{
					if (len + b > maxWidth)
					{
						len = len - words[x].Length;
						b--;
						x--;
					}

					if (x == words.Length - 1)
					{
						for (int y = p; y < x + 1; y++)
						{
							if (y != words.Length - 1)
							{
								sb.Append(words[y] + ' ');
							}
							else
							{
								sb.Append(words[y] + new string(' ', maxWidth - len - b));
								result.Add(sb.ToString());
								return result;
							}
						}
					}

					for (int j = p; j < x + 1; j++)
					{
						if (j >= x)
						{
							sb.Append(words[j]);

							if (sb.Length > maxWidth)
							{
								int i = sb.Length - 1;
								while (sb.Length > maxWidth)
								{
									if (sb[i] == ' ')
									{
										sb.Remove(i, 1);
										i -= 2;
									}

									i--;
								}
							}

							if (sb.Length < maxWidth)
							{
								sb.Append(new string(' ', maxWidth - words[x].Length));
							}

							result.Add(sb.ToString());
							sb.Clear();
						}
						else
						{
							sb.Append(words[j]);
							sb.Append(new string(' ', (int)Math.Ceiling((double)(maxWidth - len) / b)));
						}
					}

					len = 0;
					b = -1;
					p = x + 1;
				}
			}

			return result;
		}
	}
}
