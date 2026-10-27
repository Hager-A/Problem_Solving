public class Solution {
    public void MoveZeroes(int[] nums) {
                    Array.Copy(nums.Where(a => a != 0).Concat(nums.Where(a => a == 0)).ToArray(), nums, nums.Count());

    }
}