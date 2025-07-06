public class Solution {
    public int SingleNumber(int[] nums) {
         if (nums.Length == 1)
 {
     return nums[0];
 }

 int x = 0;
 for(int i = 0; i < nums.Length; i++)
 {
     int y = Array.IndexOf(nums,nums[i]);
     x = Array.LastIndexOf(nums, nums[i]);
     if (y==x)
     {
         return nums[i];

     }
 }
 return x;
    }
}