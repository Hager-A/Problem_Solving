public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
          int[] res = [];

 for(int i = 0; i < nums1.Count(); i++)
 {
     int index = Array.IndexOf(nums2, nums1[i]);
     if(index != -1)
     {
         res = res.Concat(new[] { nums1[i] }).ToArray();
         nums2 = nums2.Where((a, i) => i != index).ToArray();
     }
 }

  return res;
    }
}