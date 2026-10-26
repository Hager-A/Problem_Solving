public class Solution {
    public int MissingNumber(int[] nums) {
         if (nums.Count() == 1)
 {
     if (nums[0] == 1)
         return 0;
     return nums[0] + 1;
 }

 var res = nums.OrderBy(a => a).ToList();
 if (res[0] == 1)
 {
     return 0;
 }
 for(int i = 0; i < res.Count()-1; i++)
 {
     if (res[i] != res[i + 1] - 1)
     {
         return res[i] + 1;
     }
 }

 return res[res.Count() - 1] + 1;
    }
}