public class Solution {
    public int ThirdMax(int[] nums) {
        nums = nums.Distinct().OrderByDescending(a => a).ToArray();
        return nums.Length>=3 ?nums.Take(3).Min(): nums.Max();

    }
}