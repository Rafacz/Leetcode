using System.Text;

namespace LC.Problems
{
    public static class ReverseWordsInAString
    {
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return "";
            }

            var arr = s.Split(' ');
            StringBuilder output = new StringBuilder();

            for (int i = arr.Length - 1; i > -1; i--)
            {
                if (arr[i] != "")
                {
                    output.Append(arr[i]);
                    output.Append(" ");
                }
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();

        }
    }
}
