public class Solution {
    public int RemoveDuplicates(int[] nums) {
         HashSet<int> numbers = new HashSet<int>();
 for (int i = 0; i < nums.Length; i++)
 {
     numbers.Add(nums[i]);
 }
 int j= 0;
 foreach (var item in numbers)
     nums[j++] = item;
 return numbers.Count;
    }
}