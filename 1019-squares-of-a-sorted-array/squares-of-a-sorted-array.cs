public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int i = 0; i < nums.Length; i++)
{
    nums[i] = nums[i] * nums[i];
}
nums = nums.OrderBy(a => a).ToArray();
return nums;
    }
}