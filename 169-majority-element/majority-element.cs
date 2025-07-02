public class Solution {
    public int MajorityElement(int[] nums) {
              int z = nums.GroupBy(s => s).OrderBy(g => g.Count()).Last().Key;

return z;
    }
}