public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int target = 1;
while (Array.IndexOf(nums, target)>=0)
{
    target++;
}
return target;
    }
}