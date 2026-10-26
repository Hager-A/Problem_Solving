public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
         var res = nums1.Take(m).Concat(nums2.Take(n)).OrderBy(a=>a);
         int i=0;
         foreach(var x in res)
 {
    nums1[i]=x;
    i++;
 }
    }
}