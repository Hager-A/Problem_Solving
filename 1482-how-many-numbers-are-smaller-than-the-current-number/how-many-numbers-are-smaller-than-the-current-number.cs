public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        return nums.Select(a => nums.Count(x => a > x)).ToArray();

        
    }
}