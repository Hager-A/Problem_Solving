public class Solution {
    public int[] TwoSum(int[] nums, int target) {
          int[] x = new int[2];
 for(int i = 0; i < nums.Length; i++)
 {
     int z = target - nums[i];
     int y = Array.IndexOf(nums, z,i+1);
     if (y >= 0)
     {
         x[0] = i;
         x[1] = y;
         
         return x;
     }
 }
 return x;
    }
}