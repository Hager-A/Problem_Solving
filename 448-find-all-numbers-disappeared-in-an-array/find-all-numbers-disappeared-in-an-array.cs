public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
         List<int> res = new List<int>();
 for (int i = 0; i < nums.Length; i++)
 {
     if (!nums.Contains(i + 1))
     {
         res.Add(i + 1);
     }
 }
 return res;
    }
}