public class Solution {
    public int Search(int[] nums, int target) {
            int index = nums.Length;
    int right = index-1;
    int left = 0;
    int mid = (right + left) / 2;

   
    while (left <= right)
    {

        if (target == nums[mid])
        {
            return mid;
        }
        else if (target < nums[mid])
        {
            right = mid - 1;

        }
        else
        {
            left = mid + 1;



        }
      
        mid = (right + left) / 2;
    }
    return -1;           
}

    }
