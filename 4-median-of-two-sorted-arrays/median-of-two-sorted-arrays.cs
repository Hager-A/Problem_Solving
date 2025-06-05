public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // step1
         int[] result = nums1.Concat(nums2).ToArray();
   Array.Sort(result);
   int x = result.Length/2;
   int len = result.Length;
   double mid;
   if (result.Length == 1)
       return result[0];
   if (len % 2 == 0)
       mid = (double)(result[x] + result[x - 1]) / (double)2;
   else
       mid = result[x];
   return mid;
    }
}