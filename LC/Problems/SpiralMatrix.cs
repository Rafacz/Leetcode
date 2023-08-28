namespace LC.Problems
{
    //54. Spiral Matrix
    public class SpiralMatrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();

            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int n = rows * cols;

            int row = 0;
            int col = 1;

            while (result.Count < n)
            {
                for (int i = row; i < cols; i++)
                {
                    result.Add(matrix[0][i]);
                }

                for (int i = 1; i < rows; i++)
                {
                    result.Add(matrix[i][cols - col]);
                }

                for (int i = rows - row - 1; i > row; i--)
                {
                    result.Add(matrix[rows - row - 1][i]);
                }

                for (int i = cols - col; i > col; i--)
                {
                    result.Add(matrix[i][col]);
                }

            }

            return result;
        }
    }
}
