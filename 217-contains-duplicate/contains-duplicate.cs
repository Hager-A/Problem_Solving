public class Solution {
    public bool ContainsDuplicate(int[] nums) {
 var num = nums.Distinct();
 return num.Count() < nums.Count();        
    }
}