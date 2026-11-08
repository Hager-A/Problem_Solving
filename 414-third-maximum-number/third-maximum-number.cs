public class Solution {
    public int ThirdMax(int[] nums) {
       var res = nums.Distinct().OrderByDescending(a => a);
        return res.Count()>=3 ?res.Take(3).Min(): res.Max();

    }
}