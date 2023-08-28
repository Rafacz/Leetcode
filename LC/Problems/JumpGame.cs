namespace LC.Problems
{
    //55. Jump Game
    public class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            int steps = nums[0];

            if (steps == 0)
            {
                return false;
            }

            for (var i = 0; i < nums.Length; i++, steps--)
            {
                steps = Math.Max(nums[i], steps);

                if (steps == 0 && i != nums.Length - 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
