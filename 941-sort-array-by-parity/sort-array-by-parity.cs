public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var Even = nums.Where(a => a % 2 == 0);
var odd = nums.Where(a => a % 2 != 0);
nums = Even.Concat(odd).ToArray();
return nums;
    }
}