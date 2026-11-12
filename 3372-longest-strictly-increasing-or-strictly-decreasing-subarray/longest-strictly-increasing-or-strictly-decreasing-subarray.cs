public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int countIncreasingSubarray = 1;
        int countDecreasingSubarray = 1;
        int max = 1;

        for(int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                if (countIncreasingSubarray > 1)
                {
                    max = Math.Max(max, countIncreasingSubarray);
                    countIncreasingSubarray = 1;
                }
                countDecreasingSubarray++;

            }
            else if (nums[i] < nums[i + 1])
            {
                if (countDecreasingSubarray > 1)
                {
                    max = Math.Max(max, countDecreasingSubarray);
                    countDecreasingSubarray = 1;
                }
                countIncreasingSubarray++;
            }
            else
            {
                if (countIncreasingSubarray > 1)
                {
                    max = Math.Max(max,countIncreasingSubarray);
                    countIncreasingSubarray = 1;
                }
                if (countDecreasingSubarray > 1)
                {
                    max = Math.Max(max, countDecreasingSubarray);
                    countDecreasingSubarray = 1;
                }

            }

        }

        if (countIncreasingSubarray > 1)
        {
            max = Math.Max(max, countIncreasingSubarray);
            countIncreasingSubarray = 1;
        }
        if (countDecreasingSubarray > 1)
        {
            max = Math.Max(max, countDecreasingSubarray);
            countDecreasingSubarray = 1;
        }

        return max;
    }
}