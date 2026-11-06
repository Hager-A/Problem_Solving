public class Solution {
    public int[] RunningSum(int[] nums) {
         int addnumber = 0;
 for(int i = 0; i < nums.Length; i++)
 {
     addnumber += nums[i];
     nums[i] = addnumber;

 }
 return nums;
    }
}