public class Solution {
    public int RemoveDuplicates(int[] nums) {
      int k = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[k - 1] != nums[i])
        {
            nums[k] = nums[i];
            k++;
        }
    }
    return k;

    }
}