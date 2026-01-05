public class Solution {
    public int[] SearchRange(int[] nums, int target) {
               if (nums.Length==0)
       {
           return [-1, -1];
       }else if (nums.Length==1)
       {
           if (nums[0] == target)
           {
               return [0, 0];
           }
           else
           {
               return [-1, -1];
           }

       }
       else
       {
           int x = Array.IndexOf(nums, target);
           int y = Array.LastIndexOf(nums, target);

           return [x, y];
       }
    }
}