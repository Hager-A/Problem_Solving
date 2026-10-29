public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
            for(int i = 0; i < nums.Length; i++)
            {
                int index = Array.IndexOf(nums, nums[i], i + 1);
                if (index - i <= k&&index>=0)
                {
                    return true;
                }
            }
            return false;
    }
}