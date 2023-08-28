namespace LC.Problems
{
    //66. Plus One
    public class PlusOne
    {
        public static int[] PlusOn(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }

            bool resize = default;

            for (int i = digits.Length - 1; i > -1; i--)
            {
                if (digits[i] != 9)
                {
                    if (digits[i] == 9 && i == 0)
                    {
                        resize = true;
                    }
                    digits[i] += 1;
                    break;
                }

                if (i != 0 && digits[i] == 9)
                {
                    digits[i] = 0;
                }

                if (i == 0)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 1;
                        resize = true;
                    }
                }
            }

            if (resize)
            {
                Array.Resize(ref digits, digits.Length + 1);
            }

            return digits;
        }
    }
}
