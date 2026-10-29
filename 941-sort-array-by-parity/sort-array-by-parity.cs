public class Solution {
    public int[] SortArrayByParity(int[] nums) {
      return nums.Where(a => a % 2 == 0).Concat(nums.Where(a => a % 2 != 0)).ToArray();
    }
}