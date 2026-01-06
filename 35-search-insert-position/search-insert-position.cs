public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int index = Array.IndexOf(nums,target);
if (index > 0)
{
    return index;
}
else
{
    if (nums.Length == 0)
    {
        return 0;
    }else if (nums.Length == 1)
    {
        if (nums[0] >= target)
        {
            return 0;
        }
        return 1;

    }
    else
    {
        if (nums[nums.Length - 1] < target)
        {
            return nums.Length;
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }
            }
            return nums.Length;
        }
          
       

    }

}

    }
}