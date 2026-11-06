public class Solution {
    public int NumIdenticalPairs(int[] nums) {
         var res = nums.GroupBy(a => a).Select(a => a.Count()).Sum(a => a * (a - 1) / 2);
 return res;
    }
}