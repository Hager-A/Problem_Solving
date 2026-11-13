public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
         for(int i = 0; i < nums1.Length; i++)
 {
     var indexx = Array.IndexOf(nums2, nums1[i]);
     var x= nums2.Where((a, index) => a > nums1[i] && index > indexx).DefaultIfEmpty(-1).First();
     
     if (x == null)
     {
         nums1[i] = -1;
     }
     else
     {
         nums1[i] = x;
     }
   
 }
 return nums1;
    }
}