public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.GroupBy(a => a).OrderByDescending(a => a.Count()).Select(a => a.Key).Take(k).ToArray();

    }
}