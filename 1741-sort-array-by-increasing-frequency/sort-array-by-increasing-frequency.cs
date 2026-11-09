public class Solution {
    public int[] FrequencySort(int[] nums) {
          return nums.GroupBy(a => a).
      OrderBy(a => a.Count()).ThenByDescending(a => a.Key)
      .SelectMany(a=> Enumerable.Repeat(a.Key,a.Count())).ToArray();
    }
}